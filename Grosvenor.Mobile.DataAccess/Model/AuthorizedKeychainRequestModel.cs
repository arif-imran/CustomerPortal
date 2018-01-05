using System;
namespace Grosvenor.Mobile.DataAccess.Model
{
	/// <summary>The authorized keychain request model.</summary>
	public class AuthorizedKeychainRequestModel
	{
		/// <summary>Gets or sets the access token.</summary>
		public string AccessToken { get; set; }

		/// <summary>Gets or sets the refresh token.</summary>
		public string RefreshToken { get; set; }
	}
}