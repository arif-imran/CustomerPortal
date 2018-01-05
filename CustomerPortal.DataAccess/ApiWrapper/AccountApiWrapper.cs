// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The account API wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    using CustomerPortal.Common;

    using Refit;

    /// <summary>The account API wrapper.</summary>
    public class AccountApiWrapper : IAccountApiWrapper
    {
        /// <summary>The my profile.</summary>
        /// <param name="accessToken">The access token.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<HttpResponseMessage> MyProfile(string accessToken)
        {
            var accountApi = RestService.For<IAccountApiWrapper>(
                new HttpClient(new AuthenticatedHttpClientHandler(accessToken))
                    {
                        BaseAddress = new Uri(
                            SharedConfig.ApiEndpoint)
                    });

            return await accountApi.MyProfile(accessToken);
        }
    }
}