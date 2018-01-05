// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PropertyFacade.cs" company="">
//   
// </copyright>
// <summary>
//   The property facade.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Facades
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading.Tasks;

    using AutoMapper;

    using CustomerPortal.Common;
    using CustomerPortal.DataAccess.ApiWrapper;
    using CustomerPortal.DataAccess.Model;
    using CustomerPortal.Facade.Helpers;
    using CustomerPortal.Facade.Models;

    using Grosvenor.Mobile.Common.Utils;

    using AccountStatementEntry = CustomerPortal.Facade.Models.AccountStatementEntry;
    using CurrentBalance = CustomerPortal.Facade.Models.CurrentBalance;

    /// <summary>The property facade.</summary>
    public class PropertyFacade : IPropertyFacade
    {
        /// <summary>
        ///     The authentication wrapper.
        /// </summary>
        private readonly IAuthenticationHelperWrapper authenticationWrapper;

        /// <summary>
        ///     The property API.
        /// </summary>
        private readonly IPropertyApiWrapper propertyApi;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyFacade"/> class. 
        /// Initializes a new instance of the
        ///     <see cref="PropertyFacade"/>
        ///     class.
        ///     Initializes a new instance of the
        ///     <see cref="PropertyFacade"/>
        ///     class.
        ///     Initializes a new instance of the
        ///     <see cref="PropertyFacade"/>
        ///     class.
        ///     Initializes a new instance of the
        ///     <see cref="PropertyFacade"/>
        ///     class.
        ///     Initializes a new instance of the
        ///     <see cref="PropertyFacade"/>
        ///     class.
        ///     Initializes a new instance of the
        ///     <see cref="PropertyFacade"/>
        ///     class.
        ///     Initializes a new instance of the
        ///     <see cref="PropertyFacade"/>
        ///     class.
        /// </summary>
        /// <param name="propertyApi">
        /// The property API.
        /// </param>
        /// <param name="authenticationHelperWrapper">
        /// The authentication helper wrapper.
        /// </param>
        public PropertyFacade(IPropertyApiWrapper propertyApi, IAuthenticationHelperWrapper authenticationHelperWrapper)
        {
            this.propertyApi = propertyApi;
            this.authenticationWrapper = authenticationHelperWrapper;
        }

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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public async Task<BaseFacadeResponseModel<AccountStatementResponseModel>> GetAccountStatement(
            AuthorizedPaginatedFacadeRequestModel requestModel)
        {
            var apiAccountStatement =
                new AccountStatementApiRequestModel
                    {
                        LeaseId =
                            requestModel.QueryParameters.GetValue(
                                MagicStrings.LeaseId,
                                true),
                        StartDate =
                            ((DateTime)requestModel.QueryParameters.GetValue(
                                MagicStrings.StartDate,
                                ListExtensions.DictReturnType.DateTime)).ToString(
                                SharedConfig.LongDateFormat,
                                CultureInfo.InvariantCulture),
                        EndDate =
                            ((DateTime)requestModel.QueryParameters.GetValue(
                                MagicStrings.EndDate,
                                ListExtensions.DictReturnType.DateTime)).ToString(
                                SharedConfig.LongDateFormat,
                                CultureInfo.InvariantCulture)
                    };

            // try api call with access token
            var runner = await this.authenticationWrapper.TraverseReauth(
                             () => this.propertyApi.GetAccountStatement(
                                 requestModel.AccessToken,
                                 apiAccountStatement.LeaseId,
                                 apiAccountStatement.StartDate,
                                 apiAccountStatement.EndDate,
                                 requestModel.Paging.PageToGet,
                                 requestModel.Paging.NumberItems),
                             requestModel.RefreshToken);

            // generic runner response that sets up the return object
            var runnerResponse = await new ApiRunnerResponseHelper().ReturnRunnerResponse(
                                     runner,
                                     new AccountStatementResponseModel(),
                                     new AccountStatementApiResponseModel());

            var mappedFacadeResponse =
                runnerResponse.FacadeResponseModel as BaseFacadeResponseModel<AccountStatementResponseModel>;

            // here we need to translate the api content response into the UI response
            if (runnerResponse.ApiContentResponseModelContent != null)
            {
                var apiResponse = runnerResponse.ApiContentResponseModelContent as AccountStatementApiResponseModel;
                if (apiResponse != null)
                    mappedFacadeResponse.Content =
                        new AccountStatementResponseModel()
                            {
                                AccountStatementEntries =
                                    Mapper.Map<IEnumerable<AccountStatementEntry>>(
                                        apiResponse.AccountStatementEntries),
                                TotalNumberOfItems = apiResponse.TotalNumberOfItems
                            };
            }

            return mappedFacadeResponse;
        }

        /// <summary>
        /// The get lease info by lease id.
        /// </summary>
        /// <param name="requestModel">
        /// The request model.
        /// </param>
        /// <returns>
        /// The
        ///     <see cref="Task"/>
        ///     .
        /// </returns>
        public async Task<BaseFacadeResponseModel<GetLeaseInfoByLeaseIdResponseModel>> GetLeaseInfoByLeaseId(
            AuthorizedFacadeRequestModel requestModel)
        {
            var apiModel =
                new GetLeaseInfoByLeaseIdApiRequestModel
                    {
                        LeaseId = requestModel.QueryParameters.GetValue(
                            MagicStrings.LeaseId,
                            true)
                    };

            // try api call with access token
            var runner = await this.authenticationWrapper.TraverseReauth(
                             () => this.propertyApi.GetLeaseInfoByLeaseId(requestModel.AccessToken, apiModel.LeaseId),
                             requestModel.RefreshToken);

            // generic runner response that sets up the return object
            var runnerResponse = await new ApiRunnerResponseHelper().ReturnRunnerResponse(
                                     runner,
                                     new GetLeaseInfoByLeaseIdResponseModel(),
                                     new GetLeaseInfoByLeaseIdApiResponseModel());

            var mappedFacadeResponse =
                runnerResponse.FacadeResponseModel as BaseFacadeResponseModel<GetLeaseInfoByLeaseIdResponseModel>;

            // here we need to translate the api content response into the UI response
            if (runnerResponse.ApiContentResponseModelContent != null)
            {
                var apiResponse =
                    runnerResponse.ApiContentResponseModelContent as GetLeaseInfoByLeaseIdApiResponseModel;

                if (mappedFacadeResponse != null)
                    if (apiResponse != null)
                        mappedFacadeResponse.Content =
                            new GetLeaseInfoByLeaseIdResponseModel()
                                {
                                    LeaseInformation = apiResponse.LeaseInformation
                                };
            }

            return mappedFacadeResponse;
        }

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
        public async Task<BaseFacadeResponseModel<GetLeasesResponseModel>> GetLeasesByUserId(
            AuthorizedFacadeRequestModel model)
        {
            // try api call with access token
            var runner = await this.authenticationWrapper.TraverseReauth(
                             () => this.propertyApi.GetLeasesByUserId(model.AccessToken),
                             model.RefreshToken);

            // generic runner response that sets up the return object
            var runnerResponse = await new ApiRunnerResponseHelper().ReturnRunnerResponse(
                                     runner,
                                     new GetLeasesResponseModel(),
                                     new GetLeasesApiResponseModel());

            var mappedFacadeResponse =
                runnerResponse.FacadeResponseModel as BaseFacadeResponseModel<GetLeasesResponseModel>;

            // here we need to translate the api content response into the UI response
            var apiResponse = runnerResponse.ApiContentResponseModelContent as GetLeasesApiResponseModel;

            if (apiResponse != null && mappedFacadeResponse != null)
                mappedFacadeResponse.Content = new GetLeasesResponseModel() { Leases = apiResponse.Leases };

            return mappedFacadeResponse;
        }

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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public async Task<BaseFacadeResponseModel<OutstandingBalanceResponseModel>> GetOutstandingBalance(
            AuthorizedFacadeRequestModel requestModel)
        {
            var apiAddLeaseModel =
                new OutstandingBalanceApiRequestModel
                    {
                        LeaseId = requestModel.QueryParameters.GetValue(
                            MagicStrings.LeaseId,
                            true)
                    };

            // try api call with access token
            var runner = await this.authenticationWrapper.TraverseReauth(
                             () => this.propertyApi.GetOutstandingBalance(
                                 requestModel.AccessToken,
                                 apiAddLeaseModel.LeaseId),
                             requestModel.RefreshToken);

            // generic runner response that sets up the return object
            var runnerResponse = await new ApiRunnerResponseHelper().ReturnRunnerResponse(
                                     runner,
                                     new OutstandingBalanceResponseModel(),
                                     new OutstandingBalanceApiResponseModel());

            var mappedFacadeResponse =
                runnerResponse.FacadeResponseModel as BaseFacadeResponseModel<OutstandingBalanceResponseModel>;

            // here we need to translate the api content response into the UI response
            var apiResponse = runnerResponse.ApiContentResponseModelContent as OutstandingBalanceApiResponseModel;

            if (apiResponse != null)
                if (mappedFacadeResponse != null)
                    mappedFacadeResponse.Content =
                        new OutstandingBalanceResponseModel
                            {
                                StatementEntries = Mapper.Map<List<CurrentBalance>>(
                                    apiResponse.StatementEntries)
                            };

            return mappedFacadeResponse;
        }
    }
}