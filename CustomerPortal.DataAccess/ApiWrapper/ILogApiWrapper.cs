// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILogApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The LogApiWrapper interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper
{
    using System.Net.Http;
    using System.Threading.Tasks;

    using Refit;

    /// <summary>The LogApiWrapper interface.</summary>
    public interface ILogApiWrapper
    {
        /// <summary>The add log entry.</summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="addLogEntryRequest">The add log entry request.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        [Post("/logapi/addlogentry")]
        [Headers("Accept: application/json", "Content-Type: application/json")]
        Task<HttpResponseMessage> AddLogEntry(
            string accessToken,
            [Body(BodySerializationMethod.Json)] string addLogEntryRequest);
    }
}