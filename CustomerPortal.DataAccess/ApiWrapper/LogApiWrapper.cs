// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The log api wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper
{
    using System.Net.Http;
    using System.Threading.Tasks;

    using CustomerPortal.Common;

    using Refit;

    /// <summary>The log api wrapper.</summary>
    public class LogApiWrapper : ILogApiWrapper
    {
        /// <summary>The add log entry.</summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="addLogEntryRequest">The add log entry request.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<HttpResponseMessage> AddLogEntry(string accessToken, string addLogEntryRequest)
        {
            var logApi = RestService.For<ILogApiWrapper>(SharedConfig.ApiEndpoint);

            var response = new HttpResponseMessage();

            try
            {
                return await logApi.AddLogEntry(accessToken, addLogEntryRequest);
            }
            catch (ApiException ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            }

            return response;
        }
    }
}