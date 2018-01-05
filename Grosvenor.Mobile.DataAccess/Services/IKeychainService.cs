using System;
namespace Grosvenor.Mobile.DataAccess.Services
{
	using Grosvenor.Mobile.DataAccess.Model;
	public interface IKeychainService
	{
		/// <summary>The get credetials Keychain Model.</summary>
		/// <returns>The <see cref="KeychainModel" />.</returns>
		KeychainModel GetCredentials();

		/// <summary>The save credetials.</summary>
		/// <param name="credentials">The credentials.</param>
		void SaveCredentials(KeychainModel credentials);

		/// <summary>delete all credentials.</summary>
		void DeleteCredentials();

		/// <summary>do credentials exist ?</summary>
		/// <returns>True or False</returns>
		bool AreCredentialsValid();

		/// <summary>The get authorized keychain request model.</summary>
		/// <returns>The <see cref="AuthorizedKeychainRequestModel" />.</returns>
		AuthorizedKeychainRequestModel GetAuthorizedKeychainRequestModel();

	}
}