// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReauthenticationResponse.cs" company="">
//   
// </copyright>
// <summary>
//   The reauthentication response.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using CustomerPortal.Facade.Enums;

    /// <summary>
    /// The reauthentication response.
    /// </summary>
    /// <typeparam name="TResult">
    /// </typeparam>
    public class ReauthenticationResponse<TResult>
    {
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        public TResult Response { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public ReauthenticationResult Result { get; set; }
    }
}