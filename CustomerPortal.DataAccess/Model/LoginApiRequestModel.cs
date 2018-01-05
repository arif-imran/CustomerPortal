// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginApiRequestModel.cs" company="">
//   
// </copyright>
// <summary>
//   The login api request model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using Newtonsoft.Json;

    /// <summary>The login API request model.</summary>
    public class LoginApiRequestModel
    {
        /// <summary>Gets or sets the email.</summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>Gets or sets the password.</summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>Gets or sets a value indicating whether remember me.</summary>
        [JsonProperty("rememberMe")]
        public bool RememberMe { get; set; }
    }
}