// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAuthenticationApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The AuthenticationApiWrapper interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper
{
    using System.Net.Http;
    using System.Threading.Tasks;

    using CustomerPortal.DataAccess.Model;

    using Refit;

    /// <summary>The AuthenticationApiWrapper interface.</summary>
    public interface IAuthenticationApiWrapper
    {
        /// <summary>The login.</summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="loginRequest">The login request.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        [Post("/authenticationapi/login")]
        [Headers("Accept: application/json", "Content-Type: application/json")]
        Task<HttpResponseMessage> Login(string accessToken, [Body] LoginApiRequestModel loginRequest);
    }
}