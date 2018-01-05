// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AccountPageViewModel.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   AccountPageViewModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Services;
using CustomerPortal.Facade.Facades;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AutoMapper;
using CustomerPortal.Facade.Models;
using System.Net;
using Xamarin.Forms;
using Grosvenor.Mobile.Common.Utils;
using CustomerPortal.Common;
using CustomerPortal.DataAccess.Model;
using Grosvenor.Mobile.DataAccess.Services;
using System.Windows.Input;

namespace CustomerPortalApp.ViewModels
{

    /// <summary>
    /// Account page view model.
    /// </summary>
    public class AccountPageViewModel : NavigationBaseViewModel
    {
        /// <summary>
        /// The property facade.
        /// </summary>
        private readonly IPropertyFacade propertyFacade;

        /// <summary>
        /// The keychain service.
        /// </summary>
        readonly IKeychainService keychainService;

        /// <summary>
        /// The navigation service.
        /// </summary>
        readonly INavigationService navigationService;

        /// <summary>
        /// The balance.
        /// </summary>
        private double balance;

        /// <summary>
        /// The navigations.
        /// </summary>
        private ObservableCollection<NavigationItemViewModel> navigations;

        /// <summary>
        /// The selected property.
        /// </summary>
        private PropertyViewModel selectedProperty;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CustomerPortalApp.ViewModels.HomePageViewModel"/> class.
        /// </summary>
        /// <param name="dialogService">Dialog service.</param>
        public AccountPageViewModel(IPageDialogService dialogService, IAuthenticationFacade authenticationFacade, INavigationService navigationService, IPropertyFacade propertyFacade,
                                    IKeychainService keychainService) : base(dialogService, authenticationFacade, navigationService)
        {
            this.keychainService = keychainService;
            this.propertyFacade = propertyFacade;
            this.Title = "Account Page";

            this.PropertySelectedCommand = new DelegateCommand<PropertyViewModel>(this.PropertySelectedAction);

            this.navigationService = navigationService;
            PopulateStaticData();
            this.ExecuteAsyncTask(async () =>
            {
                await Task.WhenAll(new Task[] {
                    this.LoadProperty()
                });
            }).Forget();
        }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>The balance.</value>
        public double Balance
        {
            get { return balance; }
            set { SetProperty(ref balance, value); }
        }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public ObservableCollection<PropertyViewModel> Properties { get; set; }

        /// <summary>
        /// Gets or sets the navigations.
        /// </summary>
        /// <value>The navigations.</value>
        public ObservableCollection<NavigationItemViewModel> Navigations
        {
            get { return navigations; }
            set { SetProperty(ref navigations, value); }
        }

        /// <summary>
        /// Gets or sets the selected property.
        /// </summary>
        /// <value>The selected property.</value>
        public PropertyViewModel SelectedProperty
        {
            get { return this.selectedProperty; }
            set { SetProperty(ref this.selectedProperty, value); }
        }

        /// <summary>
        /// Gets the item tapped command.
        /// </summary>
        /// <value>The item tapped command.</value>
        public DelegateCommand<NavigationItemViewModel> ItemTappedCommand => new DelegateCommand<NavigationItemViewModel>(this.TableSelection);

        /// <summary>
        /// Gets or sets the property selected command.
        /// </summary>
        /// <value>The property selected command.</value>
        public ICommand PropertySelectedCommand { get; set; }

        /// <summary>
        /// Ons the navigated to.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

        /// <summary>
        /// Properties the selected action.
        /// </summary>
        /// <param name="property">Property.</param>
        private void PropertySelectedAction(PropertyViewModel property)
        {
            this.SelectedProperty = property;

            this.Balance = 0.0;

            if (property.AccountBalance.HasValue)
            {
                this.Balance = property.AccountBalance.Value;
            }
        }

        /// <summary>
        /// Tables the selection.
        /// </summary>
        /// <param name="parameter">Parameter.</param>
        private void TableSelection(NavigationItemViewModel parameter)
        {
            var item = parameter as NavigationItemViewModel;
            if (item != null)
            {
                if (item.ItemTappedCommand != null)
                    item.ItemTappedCommand.Execute(parameter);
            }
        }

        /// <summary>
        /// Loads the property.
        /// </summary>
        /// <returns>The property.</returns>
        private async Task LoadProperty()
        {

            var result =
                await this.propertyFacade.GetLeasesByUserId(Mapper.Map<AuthorizedFacadeRequestModel>(this.keychainService.GetAuthorizedKeychainRequestModel()));

            if (result.StatusCode == HttpStatusCode.OK)
            {
                Device.BeginInvokeOnMainThread(() => { this.ReloadPropertyCarousel(result.Content.Leases); });
            }
            else
            {
                await this.DialogService.DisplayAlertAsync(
                    GrosvenorConstants.ApiCallErrorMessageTitle,
                    Constants.LeaseErrorMessage,
                    GrosvenorConstants.ApiCallErrorMessageOkButton);
            }
        }

        /// <summary>
        /// Reloads the property carousel.
        /// </summary>
        /// <param name="leases">Leases.</param>
        private void ReloadPropertyCarousel(List<LeaseOverview> leases)
        {
            if (leases == null || leases.Count == 0) return;

            this.Properties.Clear();

            foreach (var lease in leases)
            {
                var mappedLease = Mapper.Map<PropertyViewModel>(lease);
                this.Properties.Add(mappedLease);
            }
        }

        /// <summary>
        /// Populates the static data.
        /// </summary>
        private void PopulateStaticData()
        {
            Navigations = new ObservableCollection<NavigationItemViewModel>();
            Navigations.Add(new NavigationItemViewModel()
            {
                Name = "Property Details",
                NavigationUrl = "PropertyDetailsPage",
                ItemTappedCommand = new DelegateCommand<NavigationItemViewModel>((navigation) => { this.ItemNavigationAction(navigation); })
            });

            Navigations.Add(new NavigationItemViewModel()
            {
                Name = "Statement",
                NavigationUrl = "AccountStatementsPage",
                ItemTappedCommand = new DelegateCommand<NavigationItemViewModel>((navigation) => { this.ItemNavigationAction(navigation); })
            });

            Navigations.Add(new NavigationItemViewModel()
            {
                Name = "Service Charge",
                NavigationUrl = "BlankPage",
                ItemTappedCommand = new DelegateCommand<NavigationItemViewModel>((navigation) => { this.BlankItemNavigationAction(navigation); })
            });

            Navigations.Add(new NavigationItemViewModel()
            {
                Name = "Billing Contact",
                NavigationUrl = "BlankPage",
                ItemTappedCommand = new DelegateCommand<NavigationItemViewModel>((navigation) => { this.BlankItemNavigationAction(navigation); })
            });

            Navigations.Add(new NavigationItemViewModel()
            {
                Name = "Maintenance",
                NavigationUrl = "BlankPage",
                ItemTappedCommand = new DelegateCommand<NavigationItemViewModel>((navigation) => { this.BlankItemNavigationAction(navigation); })
            });

            Properties = new ObservableCollection<PropertyViewModel>();
        }

        /// <summary>
        /// Items the navigation action.
        /// </summary>
        /// <param name="navigation">Navigation.</param>
        private void ItemNavigationAction(NavigationItemViewModel navigation)
        {
            if (string.IsNullOrEmpty(navigation.NavigationUrl) || this.SelectedProperty == null)
            {
                return;
            }

            navigation.LeaseId = this.SelectedProperty.LeaseId;

            var navigationParams = new NavigationParameters();
            navigationParams.Add(MagicStrings.Lease, this.SelectedProperty);

            this.navigationService.NavigateAsync(navigation.NavigationUrl, navigationParams, false, true).Forget();
        }

        private void BlankItemNavigationAction(NavigationItemViewModel navigation)
        {
            if (string.IsNullOrEmpty(navigation.NavigationUrl) || this.SelectedProperty == null)
            {
                return;
            }

            var navigationParams = new NavigationParameters();
            navigationParams.Add("Title", navigation.Name);

            this.navigationService.NavigateAsync(navigation.NavigationUrl, navigationParams, false, true).Forget();
        }
    }
}

