// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PropertyApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The property API wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    using CustomerPortal.Common;

    using Refit;

    /// <summary>
    ///     The property API wrapper.
    /// </summary>
    public class PropertyApiWrapper : IPropertyApiWrapper
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
        public async Task<HttpResponseMessage> GetAccountStatement(
            string accessToken,
            Guid leaseId,
            string startDate,
            string endDate,
            int pageToGet,
            int numberItems)
        {
            var propertyApi = RestService.For<IPropertyApiWrapper>(
                new HttpClient(new AuthenticatedHttpClientHandler(accessToken))
                    {
                        BaseAddress = new Uri(
                            SharedConfig.ApiEndpoint)
                    });

            var result = await propertyApi.GetAccountStatement(
                             accessToken,
                             leaseId,
                             startDate,
                             endDate,
                             pageToGet,
                             numberItems);

            return result;
        }

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
        public async Task<HttpResponseMessage> GetLeaseInfoByLeaseId(string accessToken, Guid leaseId)
        {
            var propertyApi = RestService.For<IPropertyApiWrapper>(
                new HttpClient(new AuthenticatedHttpClientHandler(accessToken))
                    {
                        BaseAddress = new Uri(
                            SharedConfig.ApiEndpoint)
                    });

            return await propertyApi.GetLeaseInfoByLeaseId(accessToken, leaseId);
        }

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
        public async Task<HttpResponseMessage> GetLeasesByUserId(string accessToken)
        {
            var propertyApi = RestService.For<IPropertyApiWrapper>(
                new HttpClient(new AuthenticatedHttpClientHandler(accessToken))
                    {
                        BaseAddress = new Uri(
                            SharedConfig.ApiEndpoint)
                    });

            HttpResponseMessage response;

            try
            {
                response = await propertyApi.GetLeasesByUserId(accessToken);
            }
            catch (ApiException ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            }

            return response;
        }

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
        public async Task<HttpResponseMessage> GetOutstandingBalance(string accessToken, Guid leaseId)
        {
            var propertyApi = RestService.For<IPropertyApiWrapper>(
                new HttpClient(new AuthenticatedHttpClientHandler(accessToken))
                    {
                        BaseAddress = new Uri(
                            SharedConfig.ApiEndpoint)
                    });

            var result = await propertyApi.GetOutstandingBalance(accessToken, leaseId);

            return result;
        }
    }
}