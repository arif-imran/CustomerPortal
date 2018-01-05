// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PropertyDetailsPageViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   The property details page view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortalApp.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;

    using AutoMapper;

    using CustomerPortal.Common;
    using CustomerPortal.Facade.Facades;
    using CustomerPortal.Facade.Models;

    using Grosvenor.Mobile.Common.Utils;
    using Grosvenor.Mobile.DataAccess.Services;

    using Prism.Navigation;
    using Prism.Services;

    using Xamarin.Forms;

    /// <summary>
    ///     The property details page view model.
    /// </summary>
    public class PropertyDetailsPageViewModel : NavigationBaseViewModel
    {
        /// <summary>
        ///     The keychain service.
        /// </summary>
        private readonly IKeychainService keychainService;

        /// <summary>
        ///     The property facade.
        /// </summary>
        private readonly IPropertyFacade propertyFacade;

        /// <summary>The account number.</summary>
        private string accountNumber;

        /// <summary>The building manager.</summary>
        private string buildingManager;

        /// <summary>The country.</summary>
        private string country;

        /// <summary>The is paid by debit.</summary>
        private string isPaidByDebit;

        /// <summary>
        /// The lease.
        /// </summary>
        private PropertyViewModel lease;

        /// <summary>The lease end of the term.</summary>
        private string leaseEndOfTheTerm;

        /// <summary>The lease start of the term.</summary>
        private string leaseStartOfTheTerm;

        /// <summary>The lease status.</summary>
        private string leaseStatus;

        /// <summary>The postcode.</summary>
        private string postcode;

        /// <summary>The property code.</summary>
        private string propertyCode;

        /// <summary>The rent.</summary>
        private double rent;

        /// <summary>The street.</summary>
        private string street;

        /// <summary>The tenant name.</summary>
        private string tenantName;

        /// <summary>The town.</summary>
        private string town;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDetailsPageViewModel"/> class. 
        /// Initializes a new instance of the
        ///     <see cref="PropertyDetailsPageViewModel"/>
        ///     class.
        ///     Initializes a new instance of the
        ///     <see cref="PropertyDetailsPageViewModel"/>
        ///     class.
        ///     Initializes a new instance of the
        ///     <see cref="PropertyDetailsPageViewModel"/>
        ///     class.
        /// </summary>
        /// <param name="dialogService">
        /// The dialog service.
        /// </param>
        /// <param name="authenticationFacade">
        /// The authentication facade.
        /// </param>
        /// <param name="propertyFacade">
        /// The property facade.
        /// </param>
        /// <param name="keychainService">
        /// The keychain Service.
        /// </param>
        public PropertyDetailsPageViewModel(
            IPageDialogService dialogService,
            IAuthenticationFacade authenticationFacade,
            IPropertyFacade propertyFacade,
            IKeychainService keychainService, 
            INavigationService navigationService)
            : base(dialogService, authenticationFacade, navigationService)
        {
            this.propertyFacade = propertyFacade;
            this.keychainService = keychainService;
        }

        /// <summary>Gets or sets the account number.</summary>
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.SetProperty(ref this.accountNumber, value);
            }
        }

        /// <summary>Gets or sets the building manager.</summary>
        public string BuildingManager
        {
            get
            {
                return this.buildingManager;
            }

            set
            {
                this.SetProperty(ref this.buildingManager, value);
            }
        }

        /// <summary>Gets or sets the country.</summary>
        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.SetProperty(ref this.country, value);
            }
        }

        /// <summary>Gets or sets the is paid by debit.</summary>
        public string IsPaidByDebit
        {
            get
            {
                return this.isPaidByDebit;
            }

            set
            {
                this.SetProperty(ref this.isPaidByDebit, value);
            }
        }

        /// <summary>Gets or sets the lease end of the term.</summary>
        public string LeaseEndOfTheTerm
        {
            get
            {
                return this.leaseEndOfTheTerm;
            }

            set
            {
                this.SetProperty(ref this.leaseEndOfTheTerm, value);
            }
        }

        /// <summary>Gets or sets the lease start of the term.</summary>
        public string LeaseStartOfTheTerm
        {
            get
            {
                return this.leaseStartOfTheTerm;
            }

            set
            {
                this.SetProperty(ref this.leaseStartOfTheTerm, value);
            }
        }

        /// <summary>Gets or sets the lease status.</summary>
        public string LeaseStatus
        {
            get
            {
                return this.leaseStatus;
            }

            set
            {
                this.SetProperty(ref this.leaseStatus, value);
            }
        }

        /// <summary>Gets or sets the postcode.</summary>
        public string Postcode
        {
            get
            {
                return this.postcode;
            }

            set
            {
                this.SetProperty(ref this.postcode, value);
            }
        }

        /// <summary>Gets or sets the property code.</summary>
        public string PropertyCode
        {
            get
            {
                return this.propertyCode;
            }

            set
            {
                this.SetProperty(ref this.propertyCode, value);
            }
        }

        /// <summary>Gets or sets the rent.</summary>
        public double Rent
        {
            get
            {
                return this.rent;
            }

            set
            {
                this.SetProperty(ref this.rent, value);
            }
        }

        /// <summary>Gets or sets the street.</summary>
        public string Street
        {
            get
            {
                return this.street;
            }

            set
            {
                this.SetProperty(ref this.street, value);
            }
        }

        /// <summary>Gets or sets the tenant name.</summary>
        public string TenantName
        {
            get
            {
                return this.tenantName;
            }

            set
            {
                this.SetProperty(ref this.tenantName, value);
            }
        }

        /// <summary>Gets or sets the city.</summary>
        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                this.SetProperty(ref this.town, value);
            }
        }

        /// <summary>
        /// The on navigated to.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            this.lease = parameters.GetValue<PropertyViewModel>(MagicStrings.Lease);

            if (this.lease != null)
                this.ExecuteAsyncTask(async () => { await this.LoadLeaseDetails(this.lease.LeaseId); }).Forget();

            base.OnNavigatedTo(parameters);
        }

        /// <summary>
        /// The load lease details.
        /// </summary>
        /// <param name="leaseId">
        /// The lease id.
        /// </param>
        /// <returns>
        /// The
        ///     <see cref="Task"/>
        ///     .
        /// </returns>
        private async Task LoadLeaseDetails(Guid leaseId)
        {
            var requestModel =
                Mapper.Map<AuthorizedFacadeRequestModel>(this.keychainService.GetAuthorizedKeychainRequestModel());

            requestModel.QueryParameters.Add(new KeyValuePair<string, object>(MagicStrings.LeaseId, this.lease.LeaseId));

            var result = await this.propertyFacade.GetLeaseInfoByLeaseId(requestModel);

            if (result.StatusCode == HttpStatusCode.OK)
                Device.BeginInvokeOnMainThread(() => { this.ReloadPropertyData(result.Content); });
            else
                await this.DialogService.DisplayAlertAsync(
                    GrosvenorConstants.ApiCallErrorMessageTitle,
                    Constants.LeaseErrorMessage,
                    GrosvenorConstants.ApiCallErrorMessageOkButton);
        }

        /// <summary>
        /// The reload property data.
        /// </summary>
        /// <param name="resultContent">
        /// The result content.
        /// </param>
        private void ReloadPropertyData(GetLeaseInfoByLeaseIdResponseModel resultContent)
        {
            if (resultContent?.LeaseInformation == null) return;

            var leaseInfo = resultContent.LeaseInformation;

            this.AccountNumber = this.lease.LeaseAccountNumber;
            this.TenantName = leaseInfo.TenantName;
            this.LeaseStatus = leaseInfo.LeaseStatus;
            this.Rent = leaseInfo.LeaseRent;
            this.LeaseStartOfTheTerm = leaseInfo.LeaseStartDate.ToString(SharedConfig.ShortDateFormat);
            if (leaseInfo.LeaseEndDate.HasValue)
                this.LeaseEndOfTheTerm = leaseInfo.LeaseEndDate.Value.ToString(SharedConfig.ShortDateFormat);
            this.IsPaidByDebit = leaseInfo.IsDirectDebit ? "Yes" : "No";
            this.PropertyCode = leaseInfo.PropertyCode;
            this.Street = leaseInfo.UnitAddress;
            this.Country = leaseInfo.UnitAddress1;
            this.Postcode = leaseInfo.UnitAddress2;
            this.BuildingManager = leaseInfo.BuildingManager;
        }
    }
}