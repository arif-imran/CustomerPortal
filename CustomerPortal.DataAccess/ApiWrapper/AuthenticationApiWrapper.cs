// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthenticationApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The authentication API wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    using CustomerPortal.Common;
    using CustomerPortal.DataAccess.Model;

    using Refit;

    /// <summary>The authentication API wrapper.</summary>
    public class AuthenticationApiWrapper : IAuthenticationApiWrapper
    {
        /// <summary>The login.</summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="loginRequest">The login request.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<HttpResponseMessage> Login(string accessToken, LoginApiRequestModel loginRequest)
        {
            var authApi = RestService.For<IAuthenticationApiWrapper>(
                new HttpClient(new AuthenticatedHttpClientHandler(accessToken))
                    {
                        BaseAddress = new Uri(
                            SharedConfig.ApiEndpoint)
                    });

            var response = new HttpResponseMessage();

            try
            {
                response = await authApi.Login(accessToken, loginRequest);
            }
            catch (ApiException ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            }

            return response;
        }
    }
}