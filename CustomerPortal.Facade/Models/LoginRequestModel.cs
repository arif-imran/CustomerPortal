// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginRequestModel.cs" company="">
//   
// </copyright>
// <summary>
//   The login request model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    /// <summary>The login request model.</summary>
    public class LoginRequestModel : AccessTokenRequestModel
    {
        /// <summary>Gets or sets a value indicating whether application uses refresh tokens.</summary>
        public bool ApplicationUsesRefreshTokens { get; set; }

        /// <summary>Gets or sets the ip address.</summary>
        public string IpAddress { get; set; }

        /// <summary>Gets or sets a value indicating whether remember me.</summary>
        public bool RememberMe { get; set; }
    }
}