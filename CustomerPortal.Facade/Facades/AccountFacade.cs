// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountFacade.cs" company="">
//   
// </copyright>
// <summary>
//   The account facade.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Facades
{
    using System.Threading.Tasks;

    using AutoMapper;

    using CustomerPortal.DataAccess.ApiWrapper;
    using CustomerPortal.DataAccess.Model;
    using CustomerPortal.Facade.Helpers;
    using CustomerPortal.Facade.Models;
	using Grosvenor.Mobile.DataAccess.Model;

    /// <summary>The account facade.</summary>
    public class AccountFacade : IAccountFacade
    {
        /// <summary>The _account api.</summary>
        private readonly IAccountApiWrapper _accountApi;

        /// <summary>The _auth wrapper.</summary>
        private readonly IAuthenticationHelperWrapper _authWrapper;

        /// <summary>Initializes a new instance of the <see cref="AccountFacade"/> class.</summary>
        /// <param name="accountApi">The account api.</param>
        /// <param name="authenticationHelperWrapper">The authentication helper wrapper.</param>
        public AccountFacade(IAccountApiWrapper accountApi, IAuthenticationHelperWrapper authenticationHelperWrapper)
        {
            this._accountApi = accountApi;
            this._authWrapper = authenticationHelperWrapper;
        }

        /// <summary>The my profile.</summary>
        /// <param name="model">The model.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<BaseFacadeResponseModel<MyProfileResponseModel>> MyProfile(AuthorizedKeychainRequestModel model)
        {
            var runner = await this._authWrapper.TraverseReauth(
                             () => this._accountApi.MyProfile(model.AccessToken),
                             model.RefreshToken);

            // generic runner response that sets up the return object
            var runnerResponse = await new ApiRunnerResponseHelper().ReturnRunnerResponse(
                                     runner,
                                     new MyProfileResponseModel(),
                                     new MyProfileApiResponseModel());

            var mappedFacadeResponse =
                runnerResponse.FacadeResponseModel as BaseFacadeResponseModel<MyProfileResponseModel>;

            // here we need to translate the api content response into the UI response
            if (runnerResponse.ApiContentResponseModelContent != null)
            {
                var apiResponse = runnerResponse.ApiContentResponseModelContent as MyProfileApiResponseModel;
                if (apiResponse != null)
                    mappedFacadeResponse.Content =
                        new MyProfileResponseModel { MyProfile = Mapper.Map<MyProfile>(apiResponse.MyProfile) };
            }

            return mappedFacadeResponse;
        }
    }
}