// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthenticationHelperWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The authentication helper wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Helpers
{
    using System;
    using System.Threading.Tasks;

    using CustomerPortal.Facade.Facades;
    using CustomerPortal.Facade.Models;

    using IdentityModel.Client;

    /// <summary>
    /// The authentication helper wrapper.
    /// </summary>
    public class AuthenticationHelperWrapper : IAuthenticationHelperWrapper
    {
        /// <summary>The get user token.</summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <param name="usingRefreshTokens">The using refresh tokens.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<TokenResponse> GetUserToken(
            string email,
            string password,
            bool usingRefreshTokens = true)
        {
            return await AuthenticationHelper.GetUserToken(email, password, usingRefreshTokens);
        }

        /// <summary>
        /// The traverse reauth.
        /// </summary>
        /// <param name="restCall">The rest call.</param>
        /// <param name="refreshToken">The refresh token.</param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ReauthenticationResponse<TResult>> TraverseReauth<TResult>(
            Func<Task<TResult>> restCall,
            string refreshToken)
        {
            return await AuthenticationHelper.TraverseReauth(restCall, refreshToken);
        }
    }
}