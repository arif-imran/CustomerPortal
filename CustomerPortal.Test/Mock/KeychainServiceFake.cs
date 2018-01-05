// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="KeychainServiceFake.cs" company="Grosvenor">
// //   
// // </copyright>
// // <summary>
// //   KeychainServiceFake
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Common;
using Prism.Services;
using System.Threading.Tasks;
using Prism.Navigation;
using System;
using Xamarin.Forms;
using Prism.Logging;
using Grosvenor.Mobile.DataAccess.Services;
using Grosvenor.Mobile.DataAccess.Model;

namespace CustomerPortal.Test
{

    public class KeychainServiceFake : IKeychainService
    {
        KeychainModel model;

        public bool AreCredentialsValid()
        {
            return this.model != null && this.model.AccessTokenExpireDate > DateTime.Now.AddMinutes(3);
        }

        public void DeleteCredentials()
        {
            this.model = null;
        }

        public AuthorizedKeychainRequestModel GetAuthorizedKeychainRequestModel()
        {
            if (this.model != null)
            {
                var credentials = new AuthorizedKeychainRequestModel()
				{
					AccessToken = this.model.AccessToken,
					RefreshToken = this.model.RefreshToken
				};
                return credentials;
            }
            else
            {
                //something to do with null
                return null;
            }
        }

        public KeychainModel GetCredentials()
        {
            return this.model;
        }

        public void SaveCredentials(KeychainModel credentials)
        {
            this.model = credentials;
        }
    }
}