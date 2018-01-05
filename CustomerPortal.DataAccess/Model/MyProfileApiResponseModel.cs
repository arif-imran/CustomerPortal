﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyProfileApiResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The my profile api response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    /// <summary>The my profile api response model.</summary>
    public class MyProfileApiResponseModel
    {
        /// <summary>Gets or sets the access token.</summary>
        public string AccessToken { get; set; }

        /// <summary>Gets or sets the my profile.</summary>
        public MyProfile MyProfile { get; set; }
    }
}