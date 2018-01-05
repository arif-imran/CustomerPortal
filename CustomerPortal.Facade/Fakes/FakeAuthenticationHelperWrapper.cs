// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FakeAuthenticationHelperWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The authentication helper wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Fakes
{
    using System;
    using System.Threading.Tasks;

    using CustomerPortal.Facade.Enums;
    using CustomerPortal.Facade.Facades;
    using CustomerPortal.Facade.Models;

    using IdentityModel.Client;

    /// <summary>
    ///     The authentication helper wrapper.
    /// </summary>
    public class FakeAuthenticationHelperWrapper : IAuthenticationHelperWrapper
    {
        /// <summary>The get user token.</summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <param name="usingRefreshTokens">The using refresh tokens.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<TokenResponse> GetUserToken(string email, string password, bool usingRefreshTokens = true)
        {
            await Task.Delay(100);

            //TODO add check. 

            var raw =
                "{\"access_token\":\"d474340d4c3af5fb84fee583e6a96599\",\"expires_in\":3600,\"token_type\":\"Bearer\"}";

            return new TokenResponse(raw);
        }

        /// <summary>The traverse reauth.</summary>
        /// <param name="restCall">The rest call.</param>
        /// <param name="refreshToken">The refresh token.</param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ReauthenticationResponse<TResult>> TraverseReauth<TResult>(
            Func<Task<TResult>> restCall,
            string refreshToken)
        {
            return new ReauthenticationResponse<TResult>
                       {
                           Result = ReauthenticationResult.NotApplicable,
                           Response = await restCall()
                       };
        }
    }
}