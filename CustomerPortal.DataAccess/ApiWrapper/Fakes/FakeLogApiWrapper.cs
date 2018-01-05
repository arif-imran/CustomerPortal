// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FakeLogApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The fake log api wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper.Fakes
{
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// The fake log api wrapper.
    /// </summary>
    public class FakeLogApiWrapper : ILogApiWrapper
    {
        /// <summary>
        /// The add log entry.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="addLogEntryRequest">The add log entry request.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<HttpResponseMessage> AddLogEntry(string accessToken, string addLogEntryRequest)
        {
            await Task.Delay(100);

            var response = new HttpResponseMessage();
            response.StatusCode = HttpStatusCode.OK;

            return response;
        }
    }
}