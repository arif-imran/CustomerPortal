using System;
using System.Linq;
using CustomerPortalApp.Droid.Services;
using Grosvenor.Mobile.Common;
using Grosvenor.Mobile.Common.Utils;
using Grosvenor.Mobile.DataAccess.Model;
using Grosvenor.Mobile.DataAccess.Services;
using Xamarin.Auth;
using Xamarin.Forms;


[assembly: Dependency(typeof(KeyStoreService))]
namespace CustomerPortalApp.Droid.Services
{
    public class KeyStoreService : IKeychainService
    {


		/// <summary>
		/// The get Keychain Model. 
		/// </summary>
		/// <returns>The <see cref="KeychainModel" />.</returns>
		public KeychainModel GetCredentials()
		{
            var account = AccountStore.Create(Forms.Context).FindAccountsForService(App.AppName).FirstOrDefault();
			if (account != null)
			{
				var credentials = new KeychainModel()
				{
					Username = account.Username,
					Password = account.Properties[GrosvenorConstants.Password],
					AccessToken = account.Properties[GrosvenorConstants.AccessToken],
					RefreshToken = account.Properties[GrosvenorConstants.RefreshToken],
					AccessTokenExpireDate = Convert.ToDateTime(account.Properties[GrosvenorConstants.AccessTokenExpireDate]),
					UserId = Guid.Parse(account.Properties[GrosvenorConstants.UserId])
				};
				return credentials;
			}
			else
			{
				//something to do with null
				return null;
			}
		}
		/// <summary>
		/// The get Authorized Keychain Request Model. 
		/// </summary>
		/// <returns>The <see cref="AuthorizedKeychainRequestModel" />.</returns>>
		public AuthorizedKeychainRequestModel GetAuthorizedKeychainRequestModel()
		{
            var account = AccountStore.Create(Forms.Context).FindAccountsForService(App.AppName).FirstOrDefault();
			if (account != null)
			{
				var credentials = new AuthorizedKeychainRequestModel()
				{
					AccessToken = account.Properties[GrosvenorConstants.AccessToken],
					RefreshToken = account.Properties[GrosvenorConstants.RefreshToken]
				};
				return credentials;
			}
			else
			{
				//something to do with null
				return null;
			}
		}
		/// <summary>
		/// Saves the credentials.
		/// </summary>
		/// <param name="credentials">Credentials.</param>
		public void SaveCredentials(KeychainModel credentials)
		{
			if (!this.AreCredentialsValid())
			{

				this.DeleteCredentials();

				Account account = new Account
				{
					Username = credentials.Username

				};
				account.Properties.Add(GrosvenorConstants.Password, credentials.Password);
				account.Properties.Add(GrosvenorConstants.AccessToken, credentials.AccessToken);
				account.Properties.Add(GrosvenorConstants.RefreshToken, credentials.RefreshToken);
				account.Properties.Add(GrosvenorConstants.AccessTokenExpireDate, credentials.AccessTokenExpireDate.ToString());
				account.Properties.Add(GrosvenorConstants.UserId, credentials.UserId.ToString());
                AccountStore.Create(Forms.Context).Save(account, App.AppName);
			}
		}
		/// <summary>
		/// Delete Credentials from Keychain. 
		/// </summary>
		public void DeleteCredentials()
		{
            var account = AccountStore.Create(Forms.Context).FindAccountsForService(App.AppName).FirstOrDefault();
			if (account != null)
			{
                AccountStore.Create(Forms.Context).Delete(account, App.AppName);
			}
		}
		/// <summary>
		/// Checking if Credentials Exist in Keychain. 
		/// </summary>
		/// <returns> true/false </returns>
		public bool AreCredentialsValid()
		{
			var creds = this.GetCredentials();
			return (creds != null && creds.AccessTokenExpireDate > DateTime.Now.AddMinutes(3));
		}
    }
}
