// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPropertyFacade.cs" company="">
//   
// </copyright>
// <summary>
//   The PropertyFacade interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Facades
{
    using System.Threading.Tasks;

    using CustomerPortal.Facade.Models;

    /// <summary>
    ///     The PropertyFacade interface.
    /// </summary>
    public interface IPropertyFacade
    {
        /// <summary>
        /// The get account statement.
        /// </summary>
        /// <param name="requestModel">
        /// The request model.
        /// </param>
        /// <returns>
        /// The
        ///     <see cref="Task"/>
        ///     .
        /// </returns>
        Task<BaseFacadeResponseModel<AccountStatementResponseModel>> GetAccountStatement(
            AuthorizedPaginatedFacadeRequestModel requestModel);

        /// <summary>
        /// The get lease info by lease id.
        /// </summary>
        /// <param name="requestModel">
        /// The request model.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<BaseFacadeResponseModel<GetLeaseInfoByLeaseIdResponseModel>> GetLeaseInfoByLeaseId(
            AuthorizedFacadeRequestModel requestModel);

        /// <summary>
        /// The get leases by user id.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <returns>
        /// The
        ///     <see cref="Task"/>
        ///     .
        /// </returns>
        Task<BaseFacadeResponseModel<GetLeasesResponseModel>> GetLeasesByUserId(AuthorizedFacadeRequestModel model);

        /// <summary>
        /// The get outstanding balance.
        /// </summary>
        /// <param name="requestModel">
        /// The request model.
        /// </param>
        /// <returns>
        /// The
        ///     <see cref="Task"/>
        ///     .
        /// </returns>
        Task<BaseFacadeResponseModel<OutstandingBalanceResponseModel>> GetOutstandingBalance(
            AuthorizedFacadeRequestModel requestModel);
    }
}