// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FakeAuthenticationApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The fake authentication api wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper.Fakes
{
    using System.Net.Http;
    using System.Threading.Tasks;

    using CustomerPortal.DataAccess.Model;

    /// <summary>
    /// The fake authentication api wrapper.
    /// </summary>
    public class FakeAuthenticationApiWrapper : FakeAipWrapperBase, IAuthenticationApiWrapper
    {
        /// <summary>
        /// The login.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="loginRequest">The login request.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<HttpResponseMessage> Login(string accessToken, LoginApiRequestModel loginRequest)
        {
            // add content 
            var content = "{\"UserDetails\":{\"UserId\":\"51d1d2ba-0196-4c60-8970-b8544cfc9d62\",\"FirstName\":\"Laura\",\"LastName\":\"Smith\",\"Email\":\"laura.smith@grosvenor.co.uk\",\"EmailConfirmed\":true,\"PasswordHash\":\"AOGxSZwbrXTFhgB0xDdcy2Fone44MxCnkHbW+II62S8KrOLU5LarRm5ezeJL7n3Iag==\",\"SecurityStamp\":\"a598082c-1137-43df-9a5c-170a1f402370\",\"PhoneNumber\":null,\"PhoneNumberConfirmed\":false,\"TwoFactorEnabled\":false,\"LockoutEndDateUtc\":\"2017-04-27T12:11:05.51\",\"LockoutEnabled\":true,\"AccessFailedCount\":0,\"Roles\":[],\"Claims\":[],\"Logins\":[],\"Id\":\"92d171c8-b360-4862-beaa-c615fb76ef72\",\"UserName\":\"laura.smith@grosvenor.co.uk\"},\"VerificationToken\":null}";

            return await this.GetFakeResponse(content);
        }
    }
}