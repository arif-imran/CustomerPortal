// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthenticationHelper.cs" company="">
//   
// </copyright>
// <summary>
//   The authentication helper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Helpers
{
    using System;
    using System.Diagnostics;
    using System.Net;
    using System.Net.Http;
    using System.Reflection;
    using System.Threading.Tasks;

    using CustomerPortal.Common;
    using CustomerPortal.Facade.Enums;
    using CustomerPortal.Facade.Models;

    using IdentityModel.Client;

    /// <summary>The authentication helper.</summary>
    public static class AuthenticationHelper
    {
        /// <summary>The request token url.</summary>
        private const string RequestTokenUrl = "core/connect/token/";

        /// <summary>The token validation.</summary>
        private const string TokenValidation = "core/connect/accesstokenvalidation?token=";

        /// <summary>The get user token.</summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <param name="usingRefreshTokens">The using refresh tokens.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public static async Task<TokenResponse> GetUserToken(
            string email,
            string password,
            bool usingRefreshTokens = true)
        {
            using (var client = new TokenClient(
                $"{SharedConfig.AuthServer}{RequestTokenUrl}",
                MagicStrings.MvcApplicationServerClientId,
                MagicStrings.MvcApplicationServerClientSecret))
            {
                var scopes = MagicStrings.GHCGBICustomerPortalApi;

                try
                {
                    return await client.RequestResourceOwnerPasswordAsync(email, password, scopes);
                }
                catch (Exception ex)
                {
                    var mesage = ex.Message;
                    return null;
                }
            }
        }

        /// <summary>The make call.</summary>
        /// <param name="restCall">The rest call.</param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns>The <see cref="Task"/>.</returns>
        public static async Task<ReauthenticationResponse<TResult>> MakeCall<TResult>(Func<Task<TResult>> restCall)
        {
            var response = await restCall();
            var statusCode = (response as HttpResponseMessage).StatusCode;

            if (statusCode != HttpStatusCode.Unauthorized)
                return new ReauthenticationResponse<TResult>
                           {
                               Result = ReauthenticationResult.Success,
                               Response = response
                           };

            return new ReauthenticationResponse<TResult>
                       {
                           Result = ReauthenticationResult.Reauthenticated,
                           Response = response,
                       };
        }

        /// <summary>The traverse reauth.</summary>
        /// <param name="restCall">The rest call.</param>
        /// <param name="refreshToken">The refresh token.</param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns>The <see cref="Task"/>.</returns>
        public static async Task<ReauthenticationResponse<TResult>> TraverseReauth<TResult>(
            Func<Task<TResult>> restCall,
            string refreshToken)
        {
            // if not using refresh tokens, then just run method
            if (string.IsNullOrWhiteSpace(refreshToken))
                return new ReauthenticationResponse<TResult>
                           {
                               Result = ReauthenticationResult.NotApplicable,
                               Response = await restCall()
                           };

            var apiResponse = await MakeCall(restCall);

            if (apiResponse.Result == ReauthenticationResult.Success)
                return new ReauthenticationResponse<TResult>
                           {
                               Result = ReauthenticationResult.Success,
                               Response = apiResponse.Response
                           };

            if (apiResponse.Result == ReauthenticationResult.Reauthenticated)
            {
                // Re-authenticate
                Debug.WriteLine("Reauthenticating...");
                var authResponse = await UseRefreshToken(refreshToken);
                if (!authResponse.IsError)
                {
                    // Debug.WriteLine("Reauthentication success.");

                    // TODO: make this work for refresh tokens
                    // (restCall.Method as AuthorizedFacadeRequestModel).AccessToken = authResponse.AccessToken;
                    // (restCall.Target as AuthorizedFacadeRequestModel).RefreshToken = authResponse.RefreshToken;
                    var parameters = restCall.GetMethodInfo().GetParameters();
                    parameters.SetValue(authResponse.AccessToken, 0);

                    var classInstance = Activator.CreateInstance(typeof(Func<TResult>), null);

                    var obj = restCall.GetMethodInfo().Invoke(classInstance, parameters);

                    // apiResponse = await MakeCall(restCall);
                    if (apiResponse.Result == ReauthenticationResult.Success)
                        return new ReauthenticationResponse<TResult>
                                   {
                                       AccessToken = authResponse.AccessToken,
                                       RefreshToken = authResponse.RefreshToken,
                                       Response = apiResponse.Response
                                   };
                }
            }

            // Failed to re-authenticate or general failure.
            Debug.WriteLine("Reauthentication failed.");
            return new ReauthenticationResponse<TResult> { Result = ReauthenticationResult.Failure };
        }

        /// <summary>The use refresh token.</summary>
        /// <param name="refreshToken">The refresh token.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public static async Task<TokenResponse> UseRefreshToken(string refreshToken)
        {
            using (var client = new TokenClient(
                $"{SharedConfig.AuthServer}{RequestTokenUrl}",
                MagicStrings.MvcApplicationServerClientId,
                MagicStrings.MvcApplicationServerClientSecret))
            {
                return await client.RequestRefreshTokenAsync(refreshToken);
            }
        }

        /// <summary>The make call again.</summary>
        /// <param name="v">The v.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        /// <exception cref="NotImplementedException"></exception>
        private static Task<ReauthenticationResponse<object>> MakeCallAgain(object v)
        {
            throw new NotImplementedException();
        }
    }
}