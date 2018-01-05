// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FakeAccountApiWrapper.cs" company="Grosvenor">
// //   
// // </copyright>
// // <summary>
// //   FakeAccountApiWrapper
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper.Fakes
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// The account API wrapper.
    /// </summary>
    public class FakeAccountApiWrapper : FakeAipWrapperBase, IAccountApiWrapper
    {
        /// <summary>The my profile.</summary>
        /// <param name="accessToken">The access token.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<HttpResponseMessage> MyProfile(string accessToken)
        {
            var content = "{\"AccessToken\":null,\"MyProfile\":{\"Title\":\"Baroness\",\"FirstName\":\"Laura\",\"LastName\":\"Smith\",\"Address1\":\"77 Villy\",\"Address2\":\"testerville_2\",\"Town\":\"glasgow   \",\"Postcode\":\"g1 5qh\",\"Country\":\"Scotland\",\"Dob\":\"1919-07-01T00:00:00\",\"EmailAddress\":\"laura.smith@grosvenor.co.uk\",\"IsSignedForExclusiveBenefits\":false,\"Gender\":\"Female\"}}";

            return await this.GetFakeResponse(content);
        }
    }

}