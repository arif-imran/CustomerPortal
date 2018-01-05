// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginApiResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The login api response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    /// <summary>The login api response model.</summary>
    public class LoginApiResponseModel
    {
        /// <summary>Gets or sets the user details.</summary>
        public UserDetails UserDetails { get; set; }

        /// <summary>Gets or sets the verification token.</summary>
        public string VerificationToken { get; set; }
    }
}