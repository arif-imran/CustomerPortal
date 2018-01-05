// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AuthenticationFacade.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   AuthenticationFacade
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using AutoMapper;
using CustomerPortal.DataAccess.ApiWrapper;
using CustomerPortal.DataAccess.Model;
using CustomerPortal.Facade.Helpers;
using CustomerPortal.Facade.Models;
using Grosvenor.Mobile.DataAccess.Model;
using Grosvenor.Mobile.DataAccess.Services;

namespace CustomerPortal.Facade.Facades
{
    /// <summary>
    /// Authentication facade.
    /// </summary>
    public class AuthenticationFacade : IAuthenticationFacade
    {
        /// <summary>
        /// The settings facade.
        /// </summary>
        readonly ISettingsFacade settingsFacade;

		private readonly IAuthenticationApiWrapper _authApi;
		private readonly ILogApiWrapper _logApi;
		private readonly IAuthenticationHelperWrapper _authenticationHelperWrapper;
		private readonly IKeychainService keychainService;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:CustomerPortal.Facade.Facades.AuthenticationFacade"/> class.
		/// </summary>
		/// <param name="settingsFacade">Settings facade.</param>
		public AuthenticationFacade(ISettingsFacade settingsFacade, IAuthenticationApiWrapper authApi, ILogApiWrapper logApi,
		    IAuthenticationHelperWrapper authenticationHelperWrapper, IKeychainService keychainService)
		{
			this.settingsFacade = settingsFacade;
			this.keychainService = keychainService;
			_authApi = authApi;
			_logApi = logApi;
			_authenticationHelperWrapper = authenticationHelperWrapper;
		}

        /// <summary>
        /// Logout this instance.
        /// </summary>
        public void Logout()
        {
            // Delete Credentials from Keychain/Keystore
            this.keychainService.DeleteCredentials();
            this.settingsFacade.DeleteAll();
            this.CurrentUser = null;
        }

        /// <summary>
        /// Gets the current user.
        /// </summary>
        /// <value>The current user.</value>
        public Models.IdentityModel CurrentUser { get; private set; }


        public async Task<BaseFacadeResponseModel<LoginResponseModel>> Login(BaseFacadeRequestModelWithContent<LoginRequestModel> model)
        {
            var apiRequestModel = Mapper.Map<LoginApiRequestModel>(model.Content);

            var authResponse = await _authenticationHelperWrapper.GetUserToken(model.Content.Email, model.Content.Password, model.Content.ApplicationUsesRefreshTokens);

            if (authResponse == null || authResponse.IsError)
            {
                //log unsuccessful login attempt
                var addLogEntryApiRequestModel = new AddLogEntryApiRequestModel
                {
                    StatusCode = 404,
                    Date = DateTime.Now,
                    Type = "Login attempt",
                    IpAddress = model.Content.IpAddress,
                    Message = "A failed login attempt occurred using the email address " + model.Content.Email
                };

                //Todo: log addLogEntryApiRequestModel

                if (authResponse != null)
                {
                    return new BaseFacadeResponseModel<LoginResponseModel>
                    {
                        //authResponse.Json.GetValue("error_description");
                        Message =
                            authResponse.Json.GetValue("error_description")
                                .ToString(), //"The username or password entered was incorrect. Please check your details and try again.",
                        StatusCode = System.Net.HttpStatusCode.Unauthorized
                    };
                }
            }

            var runner = await _authenticationHelperWrapper.TraverseReauth(() => _authApi.Login(authResponse.AccessToken, apiRequestModel), authResponse.RefreshToken);

            //generic helper that sets up the return object
            var runnerResponse = await new ApiRunnerResponseHelper().ReturnRunnerResponse(runner, new LoginResponseModel(), new LoginApiResponseModel());

            var mappedFacadeResponse = (runnerResponse.FacadeResponseModel as BaseFacadeResponseModel<LoginResponseModel>);

            mappedFacadeResponse.AccessToken = authResponse.AccessToken;
            mappedFacadeResponse.RefreshToken = authResponse.RefreshToken ?? string.Empty;

            //here we need to translate the api content response into the UI response
            if (runnerResponse.ApiContentResponseModelContent != null)
            {
                var apiResponse = (runnerResponse.ApiContentResponseModelContent as LoginApiResponseModel);
                mappedFacadeResponse.Content = new LoginResponseModel
                {
                    UserDetails = apiResponse.UserDetails,
                    VerificationToken = apiResponse.VerificationToken,
                    UserId = apiResponse.UserDetails.UserId
                };
            }
            else
            {
                //log unsuccessful login attempt
                var addLogEntryApiRequestModel = new AddLogEntryApiRequestModel
                {
                    StatusCode = 404,
                    Date = DateTime.Now,
                    Type = "Login attempt",
                    IpAddress = model.Content.IpAddress,
                    Message = "A failed login attempt occurred using the email address " + model.Content.Email
                };

                //Todo: reinstate this log entry
                //await _logApi.AddLogEntry();
            }

			var Credentials = new KeychainModel()
			{
				Username = model.Content.Email,
				Password = model.Content.Password,
				AccessToken = mappedFacadeResponse.AccessToken,
				RefreshToken = mappedFacadeResponse.RefreshToken,
				AccessTokenExpireDate = DateTime.Now.AddMinutes(20),
				UserId = mappedFacadeResponse.Content.UserId
			};
			this.keychainService.SaveCredentials(Credentials);

            return mappedFacadeResponse;
        }
    }
}