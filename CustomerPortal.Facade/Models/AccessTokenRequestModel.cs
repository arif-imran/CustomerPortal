// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccessTokenRequestModel.cs" company="">
//   
// </copyright>
// <summary>
//   The access token request model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    /// <summary>The access token request model.</summary>
    public class AccessTokenRequestModel
    {
        /// <summary>Gets or sets the email.</summary>
        public string Email { get; set; }

        /// <summary>Gets or sets the password.</summary>
        public string Password { get; set; }
    }
}