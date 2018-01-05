// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizedFacadeRequestModel.cs" company="">
//   
// </copyright>
// <summary>
//   The authorized facade request model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    /// <summary>The authorized facade request model.</summary>
    public class AuthorizedFacadeRequestModel : BaseFacadeRequestModel
    {
        /// <summary>Gets or sets the access token.</summary>
        public string AccessToken { get; set; }

        /// <summary>Gets or sets the refresh token.</summary>
        public string RefreshToken { get; set; }
    }
}