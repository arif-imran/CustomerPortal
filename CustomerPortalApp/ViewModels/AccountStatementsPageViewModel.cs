using System;
using System.Collections.ObjectModel;
using System.Linq;
using CustomerPortal.Facade.Facades;
using Prism.Services;
using Prism.Mvvm;
using System.Collections.Generic;
using Prism.Commands;

namespace CustomerPortalApp.ViewModels
{
    using System.Net;
    using System.Threading.Tasks;

    using AutoMapper;
    using CustomerPortal.Common;
    using CustomerPortal.Facade.Models;

    using Grosvenor.Mobile.Common.Utils;
    using Grosvenor.Mobile.DataAccess.Services;
    using Prism.Navigation;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    public class AccountStatementsPageViewModel : NavigationBaseViewModel
    {
        private readonly IPropertyFacade propertyFacade;

        private readonly IKeychainService keychainService;

        /// <summary>
        /// The properties.
        /// </summary>
        private PropertyViewModel properties;

        /// <summary>
        /// The statements.
        /// </summary>
        private ObservableCollection<StatementsViewModel> statements;

        /// <summary>
        /// The current balance.
        /// </summary>
		private ObservableCollection<StatementsViewModel> currentBalance;

        /// <summary>
        /// The net due.
        /// </summary>
        private double netDue;

        /// <summary>
        /// The unallocated total.
        /// </summary>
        private double unallocatedTotal;

        /// <summary>
        /// The upcoming charges.
        /// </summary>
        private double upcomingCharges;

        /// <summary>
        /// The balance.
        /// </summary>
        private double balance;

        /// <summary>
        /// The source.
        /// </summary>
        private object source;

        /// <summary>
        /// The active tab title.
        /// </summary>
        private string activeTabTitle = "Statement";

        /// <summary>
        /// The is current balacne tab.
        /// </summary>
        private bool isCurrentBalacneTab;

        /// <summary>
        /// The is statement tab.
        /// </summary>
        private bool isStatementTab;

        /// <summary>
        /// The is data available.
        /// </summary>
        private bool isStatementAvailable;

        /// <summary>
        /// The is current balance available.
        /// </summary>
        private bool isCurrentBalanceAvailable;

        public AccountStatementsPageViewModel(IPageDialogService dialogService,
            IAuthenticationFacade authenticationFacade,
            IPropertyFacade propertyFacade,
            IKeychainService keychainService,
            INavigationService navigationService)
            : base(dialogService, authenticationFacade, navigationService)
        {
            this.propertyFacade = propertyFacade;
            this.keychainService = keychainService;
            this.properties = new PropertyViewModel();
            this.Statements = new ObservableCollection<StatementsViewModel>();
            this.CurrentBalance = new ObservableCollection<StatementsViewModel>();
        }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public PropertyViewModel Properties
        {
            get { return this.properties; }

            set { this.SetProperty(ref this.properties, value); }
        }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public ObservableCollection<StatementsViewModel> Statements
        {
            get { return this.statements; }

            set { this.SetProperty(ref this.statements, value); }
        }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        /// <value>The events.</value>
        public ObservableCollection<StatementsViewModel> CurrentBalance
        {
            get { return this.currentBalance; }

            set { this.SetProperty(ref this.currentBalance, value); }
        }

        /// <summary>
        /// Gets or sets the net due.
        /// </summary>
        /// <value>The net due.</value>
        public double NetDue
        {
            get
            {
                return this.netDue;
            }

            set
            {
                this.SetProperty(ref this.netDue, value);
            }
        }

        /// <summary>
        /// Gets or sets the unallocated total.
        /// </summary>
        /// <value>The unallocated total.</value>
		public double UnallocatedTotal
        {
            get
            {
                return this.unallocatedTotal;
            }

            set
            {
                this.SetProperty(ref this.unallocatedTotal, value);
            }
        }

        /// <summary>
        /// Gets or sets the upcoming charges.
        /// </summary>
        /// <value>The upcoming charges.</value>
		public double UpcomingCharges
        {
            get
            {
                return this.upcomingCharges;
            }

            set
            {
                this.SetProperty(ref this.upcomingCharges, value);
            }
        }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>The balance.</value>
		public double Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.SetProperty(ref this.balance, value);
            }
        }

        /// <summary>
        /// Gets or sets the active tab title.
        /// </summary>
        /// <value>The active tab title.</value>
        public string ActiveTabTitle
        {
            get { return this.activeTabTitle; }

            set { this.SetProperty(ref this.activeTabTitle, value); }
        }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public object Source
        {
            get { return this.source; }

            set { this.SetProperty(ref this.source, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:CustomerPortalApp.ViewModels.AccountStatementsPageViewModel"/> is current balance tab.
        /// </summary>
        /// <value><c>true</c> if is current balance tab; otherwise, <c>false</c>.</value>
        public bool IsCurrentBalanceTab
        {
            get { return this.isCurrentBalacneTab; }
            set { this.SetProperty(ref this.isCurrentBalacneTab, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:CustomerPortalApp.ViewModels.AccountStatementsPageViewModel"/> is statement tab.
        /// </summary>
        /// <value><c>true</c> if is statement tab; otherwise, <c>false</c>.</value>
		public bool IsStatementTab
        {
            get { return this.isStatementTab; }
            set { this.SetProperty(ref this.isStatementTab, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:CustomerPortalApp.ViewModels.AccountStatementsPageViewModel"/> is data available.
        /// </summary>
        /// <value><c>true</c> if is data available; otherwise, <c>false</c>.</value>
		public bool IsStatementAvailable
        {
            get
            {
                return this.isStatementAvailable;
            }
            set
            {
                SetProperty(ref this.isStatementAvailable, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:CustomerPortalApp.ViewModels.AccountStatementsPageViewModel"/> is current balance available.
        /// </summary>
        /// <value><c>true</c> if is current balance available; otherwise, <c>false</c>.</value>
		public bool IsCurrentBalanceAvailable
        {
            get
            {
                return this.isCurrentBalanceAvailable;
            }
            set
            {
                SetProperty(ref this.isCurrentBalanceAvailable, value);
            }
        }

        /// <summary>
        /// Gets the table selection command.
        /// </summary>
        /// <value>The table selection command.</value>
        public DelegateCommand<string> TableSelectionCommand => new DelegateCommand<string>(this.TableSelection)
          .ObservesProperty(() => this.ActiveTabTitle);

        /// <summary>
        /// Ons the navigated to.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        public override void OnNavigatedTo(Prism.Navigation.NavigationParameters parameters)
        {
            this.Properties = parameters.GetValue<PropertyViewModel>(MagicStrings.Lease);

            this.ExecuteAsyncTask(async () =>
            {
                await Task.WhenAll(new Task[] {
                                                      this.LoadAccountStatement(),
                                                      this.LoadCurrentBalance(),
                                                  });
            }).Forget();

            base.OnNavigatedTo(parameters);
        }

        private async Task LoadAccountStatement()
        {
            var atuhorizedRequestModel =
                Mapper.Map<AuthorizedFacadeRequestModel>(this.keychainService.GetAuthorizedKeychainRequestModel());

            var requestModel =
                new AuthorizedPaginatedFacadeRequestModel
                {
                    AccessToken = atuhorizedRequestModel.AccessToken,
                    RefreshToken = atuhorizedRequestModel.RefreshToken,
                    Paging = new PaginationConfigModel { PageToGet = 1, NumberItems = 10 },
                    QueryParameters = new List<KeyValuePair<string, object>>
                                              {
                    new KeyValuePair<string, object>(MagicStrings.LeaseId, this.Properties.LeaseId),
                    new KeyValuePair<string, object>(MagicStrings.StartDate, DateTime.Now.AddYears(-1).AddDays(-10)),
                    new KeyValuePair<string, object>(MagicStrings.EndDate, DateTime.Now.AddDays(-10))
                }
                };

            var result = await this.propertyFacade.GetAccountStatement(requestModel);

            if (result.StatusCode == HttpStatusCode.OK)
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    this.ReloadStatement(result.Content);
                });
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
        /// Loads the current balance.
        /// </summary>
        /// <returns>The current balance.</returns>
        private async Task LoadCurrentBalance()
        {
            var requestModel =
                Mapper.Map<AuthorizedFacadeRequestModel>(this.keychainService.GetAuthorizedKeychainRequestModel());

            requestModel.QueryParameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>(MagicStrings.LeaseId, this.Properties.LeaseId)
            };

            var result = await this.propertyFacade.GetOutstandingBalance(requestModel);

            if (result.StatusCode == HttpStatusCode.OK)
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    this.ReloadCurrentBallance(result.Content);
                });
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
        /// Reloads the current ballance.
        /// </summary>
        /// <param name="content">Content.</param>
        private void ReloadCurrentBallance(OutstandingBalanceResponseModel content)
        {
            this.CurrentBalance?.Clear();

            var unsortedItems = Mapper.Map<List<StatementsViewModel>>(content.StatementEntries);

            unsortedItems = unsortedItems.OrderByDescending(x => x.DueDateDate).ToList();

            foreach (var balanceItem in unsortedItems)
            {
                var resultItemm = Mapper.Map<StatementsViewModel>(balanceItem);

                resultItemm.Type = StatementsViewModel.StatementType.Balance;

                this.CurrentBalance.Add(resultItemm);

                if (resultItemm.DueDateDate > DateTime.Now)
                {
                    this.UpcomingCharges += resultItemm.InvoiceAmount;
                }
                else
                {
                    this.NetDue += resultItemm.NetDue;
                }

                this.UnallocatedTotal += resultItemm.Payments;
            }

            this.Balance = this.NetDue + this.UpcomingCharges - this.UnallocatedTotal;
        }

        /// <summary>
        /// Reloads the statement.
        /// </summary>
        /// <param name="content">Content.</param>
        private void ReloadStatement(AccountStatementResponseModel content)
        {
            this.Statements.Clear();

            if (content?.AccountStatementEntries == null)
            {
                return;
            }

            foreach (var statement in content.AccountStatementEntries)
            {
                var newStatement = Mapper.Map<StatementsViewModel>(statement);

                newStatement.Type = StatementsViewModel.StatementType.Statement;

                this.Statements.Add(newStatement);
            }
            this.PopulateStatementData();
        }

        /// <summary>
        /// Populates the statement data.
        /// </summary>
        public void PopulateStatementData()
        {
            this.IsStatementAvailable = this.Statements.Count > 0 ? true : false;
            this.Statements = new ObservableCollection<StatementsViewModel>(this.Statements.OrderByDescending(o => String.Format(SharedConfig.SortDateFormat, o.DueDate)));

            this.IsStatementTab = true;
            this.IsCurrentBalanceTab = false;
            for (int i = 0; i < this.Statements.Count; i++)
            {
                this.Statements[i].Index = i;
            }

            this.Source = this.Statements.GroupBy(g => g.Year)
                .OrderByDescending(o => o.Key.ToString());
        }

        /// <summary>
        /// Tables the selection.
        /// </summary>
        /// <param name="parameter">Parameter.</param>
        private void TableSelection(string parameter)
        {
            this.Source = new object();

            if (parameter == "Statement")
            {
                this.ActiveTabTitle = "Statement";
                this.IsCurrentBalanceTab = false;
                this.IsStatementTab = true;
                PopulateStatementData();
            }

            if (parameter == "CurrentBalance")
            {

                this.ActiveTabTitle = "CurrentBalance";
                this.IsCurrentBalanceTab = true;
                this.IsStatementTab = false;
                this.IsCurrentBalanceAvailable = this.CurrentBalance.Count > 0 ? true : false;
                this.CurrentBalance = new ObservableCollection<StatementsViewModel>(this.CurrentBalance.OrderByDescending(o => String.Format(SharedConfig.SortDateFormat, o.DueDate)));
                for (int i = 0; i < this.CurrentBalance.Count; i++)
                {
                    this.CurrentBalance[i].Index = i;
                }
                this.Source = this.CurrentBalance.GroupBy(g => g.Year)
                    .OrderByDescending(o => o.Key.ToString());
            }
        }

    }

}
