// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyProfileResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The my profile response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using CustomerPortal.DataAccess.Model;

    /// <summary>The my profile response model.</summary>
    public class MyProfileResponseModel
    {
        /// <summary>Gets or sets the access token.</summary>
        public string AccessToken { get; set; }

        /// <summary>Gets or sets the my profile.</summary>
        public MyProfile MyProfile { get; set; }
    }
}