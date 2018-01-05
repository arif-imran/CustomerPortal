// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPropertyApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The Property API Wrapper interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Refit;

    /// <summary>
    ///     The Property API Wrapper interface.
    /// </summary>
    public interface IPropertyApiWrapper
    {
        /// <summary>
        /// The get account statement.
        /// </summary>
        /// <param name="accessToken">
        /// The access token.
        /// </param>
        /// <param name="leaseId">
        /// The lease id.
        /// </param>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        /// <param name="pageToGet">
        /// The page to get.
        /// </param>
        /// <param name="numberItems">
        /// The number items.
        /// </param>
        /// <returns>
        /// The
        ///     <see cref="Task"/>
        ///     .
        /// </returns>
        [Get("/PropertyApi/AccountStatement")]
        [Headers("Accept: application/json", "Content-Type: application/json")]
        Task<HttpResponseMessage> GetAccountStatement(
            string accessToken,
            Guid leaseId,
            string startDate,
            string endDate,
            int pageToGet,
            int numberItems);

        /// <summary>
        /// The get lease info by lease id.
        /// </summary>
        /// <param name="accessToken">
        /// The access token.
        /// </param>
        /// <param name="leaseId">
        /// The lease id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Get("/PropertyApi/LeaseInformation")]
        [Headers("Accept: application/json", "Content-Type: application/json")]
        Task<HttpResponseMessage> GetLeaseInfoByLeaseId(string accessToken, Guid leaseId);

        /// <summary>
        /// The get leases by user id.
        /// </summary>
        /// <param name="accessToken">
        /// The access token.
        /// </param>
        /// <returns>
        /// The
        ///     <see cref="Task"/>
        ///     .
        /// </returns>
        [Get("/PropertyApi/Leases")]
        [Headers("Accept: application/json", "Content-Type: application/json")]
        Task<HttpResponseMessage> GetLeasesByUserId(string accessToken);

        /// <summary>
        /// The get outstanding balance.
        /// </summary>
        /// <param name="accessToken">
        /// The access token.
        /// </param>
        /// <param name="leaseId">
        /// The lease id.
        /// </param>
        /// <returns>
        /// The
        ///     <see cref="Task"/>
        ///     .
        /// </returns>
        [Get("/PropertyApi/OutstandingBalance")]
        [Headers("Accept: application/json", "Content-Type: application/json")]
        Task<HttpResponseMessage> GetOutstandingBalance(string accessToken, Guid leaseId);
    }
}