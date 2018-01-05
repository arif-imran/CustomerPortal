using System;
namespace Grosvenor.Mobile.DataAccess.Model
{
	public class KeychainModel
	{

		/// <summary>Gets or sets the username.</summary>
		public string Username { get; set; }

		/// <summary>Gets or sets the password.</summary>
		public string Password { get; set; }

		/// <summary>Gets or sets the refresh token.</summary>
		public string RefreshToken { get; set; }

		/// <summary>Gets or sets the access token.</summary>
		public string AccessToken { get; set; }

		/// <summary>Gets or sets the access token expire date.</summary>
		public DateTime AccessTokenExpireDate { get; set; }

		/// <summary>Gets or sets the user id.</summary>
		public Guid UserId { get; set; }

	}
}
