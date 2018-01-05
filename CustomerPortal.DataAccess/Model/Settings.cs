// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Settings.cs" company="">
//   
// </copyright>
// <summary>
//   The settings.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System;

    using Grosvenor.Mobile.DataAccess.Model;

    using SQLite;

    /// <summary>The settings.</summary>
    [Table("Settings")]
    public class Settings : BaseEntity
    {
        /// <summary>The access token.</summary>
        private string accessToken;

        /// <summary>The access token expire date.</summary>
        private DateTime accessTokenExpireDate;

        /// <summary>The password.</summary>
        private string password;

        /// <summary>The refresh token.</summary>
        private string refreshToken;

        /// <summary>The username.</summary>
        private string username;

        /// <summary>Gets or sets the access token.</summary>
        public string AccessToken
        {
            get
            {
                return this.accessToken;
            }

            set
            {
                this.SetProperty(ref this.accessToken, value);
            }
        }

        /// <summary>Gets or sets the access token expire date.</summary>
        public DateTime AccessTokenExpireDate
        {
            get
            {
                return this.accessTokenExpireDate;
            }

            set
            {
                this.SetProperty(ref this.accessTokenExpireDate, value);
            }
        }

        /// <summary>Gets or sets the password.</summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.SetProperty(ref this.password, value);
            }
        }

        /// <summary>Gets or sets the refresh token.</summary>
        public string RefreshToken
        {
            get
            {
                return this.refreshToken;
            }

            set
            {
                this.SetProperty(ref this.refreshToken, value);
            }
        }

        /// <summary>Gets or sets the username.</summary>
        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                this.SetProperty(ref this.username, value);
            }
        }
    }
}