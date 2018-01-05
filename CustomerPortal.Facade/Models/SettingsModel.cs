﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SettingsModel.cs" company="">
//   
// </copyright>
// <summary>
//   The settings model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System;

    /// <summary>The settings model.</summary>
    public class SettingsModel
    {
        /// <summary>Gets or sets the access token.</summary>
        public string AccessToken { get; set; }

        /// <summary>Gets or sets the access token expire date.</summary>
        public DateTime AccessTokenExpireDate { get; set; }

        /// <summary>Gets or sets the id.</summary>
        public int Id { get; set; }

        /// <summary>Gets a value indicating whether is valid user.</summary>
        public bool IsValidUser
        {
            get
            {
                return !string.IsNullOrEmpty(this.AccessToken)
                       && this.AccessTokenExpireDate > DateTime.Now.AddSeconds(30);
            }
        }

        /// <summary>Gets or sets the password.</summary>
        public string Password { get; set; }

        /// <summary>Gets or sets the refresh token.</summary>
        public string RefreshToken { get; set; }

        /// <summary>Gets the user id.</summary>
        public Guid UserId { get; internal set; }

        /// <summary>Gets or sets the username.</summary>
        public string Username { get; set; }
    }
}