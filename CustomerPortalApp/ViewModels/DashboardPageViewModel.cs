// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DashboardPageViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   Dashboard page view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortalApp.ViewModels{    using System.Collections.Generic;    using System.Collections.ObjectModel;    using System.Net;    using System.Threading.Tasks;    using AutoMapper;    using CustomerPortal.Common;    using CustomerPortal.DataAccess.Model;    using CustomerPortal.Facade.Facades;    using CustomerPortal.Facade.Models;    using Grosvenor.Mobile.Common.Utils;
    using Grosvenor.Mobile.DataAccess.Services;    using Prism.Commands;    using Prism.Navigation;    using Prism.Services;    using Xamarin.Forms;    using Story = CustomerPortal.Facade.Models.Story;

    /// <summary>    ///     Dashboard page view model.    /// </summary>
    public class DashboardPageViewModel : NavigationBaseViewModel    {
        /// <summary>
        /// The property facade.
        /// </summary>
        private readonly IPropertyFacade propertyFacade;

        /// <summary>
        /// The settings facade.
        /// </summary>        private readonly ISettingsFacade settingsFacade;


        /// <summary>
        /// The story facade.
        /// </summary>        private readonly IStoryFacade storyFacade;

        /// <summary>
        /// The active tab data.
        /// </summary>        private ObservableCollection<StoryViewModel> activeTabData;

        /// <summary>
        /// The active tab title.
        /// </summary>        private string activeTabTitle = "My Community";

        /// <summary>
        /// The properties.
        /// </summary>        private ObservableCollection<PropertyViewModel> properties;

        /// <summary>
        /// The keychain service.
        /// </summary>
        readonly IKeychainService keychainService;

        /// <summary>
        /// The navigation service.
        /// </summary>
        readonly INavigationService navigationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CustomerPortalApp.ViewModels.DashboardPageViewModel"/> class.
        /// </summary>
        /// <param name="dialogService">Dialog service.</param>
        /// <param name="authenticationFacade">Authentication facade.</param>
        /// <param name="settingsFacade">Settings facade.</param>
        /// <param name="propertyFacade">Property facade.</param>
        /// <param name="storyFacade">Story facade.</param>
        /// <param name="keychainService">Keychain service.</param>        public DashboardPageViewModel(
          IPageDialogService dialogService,
          IAuthenticationFacade authenticationFacade,
          ISettingsFacade settingsFacade,
            INavigationService navigationService,
          IPropertyFacade propertyFacade,
          IStoryFacade storyFacade,
            IKeychainService keychainService)
          : base(dialogService, authenticationFacade)        {
            this.keychainService = keychainService;
            this.settingsFacade = settingsFacade;            this.propertyFacade = propertyFacade;            this.storyFacade = storyFacade;            this.Title = Constants.PageTitleDashboard;            this.navigationService = navigationService;
            this.properties = new ObservableCollection<PropertyViewModel>();
            this.Communities = new ObservableCollection<StoryViewModel>();
            this.Events = new ObservableCollection<StoryViewModel>();
            this.ActiveTabData = new ObservableCollection<StoryViewModel>();

            this.ExecuteAsyncTask(async () =>
            {
                await Task.WhenAll(new Task[] {
                    this.LoadProperty(),
                    this.LoadStories("event"),
                    this.LoadStories("story")
                });
            }).Forget();

            PopulateFakeProperties();        }

        /// <summary>
        /// Gets or sets the active tab data.
        /// </summary>
        /// <value>The active tab data.</value>        public ObservableCollection<StoryViewModel> ActiveTabData        {            get { return this.activeTabData; }            set { this.SetProperty(ref this.activeTabData, value); }        }

        /// <summary>
        /// Gets or sets the active tab title.
        /// </summary>
        /// <value>The active tab title.</value>        public string ActiveTabTitle        {            get { return this.activeTabTitle; }            set { this.SetProperty(ref this.activeTabTitle, value); }        }

        /// <summary>
        /// Gets or sets the communities.
        /// </summary>
        /// <value>The communities.</value>        public ObservableCollection<StoryViewModel> Communities { get; set; }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        /// <value>The events.</value>        public ObservableCollection<StoryViewModel> Events { get; set; }

        /// <summary>
        /// Gets or sets the offers.
        /// </summary>
        /// <value>The offers.</value>        public OfferViewModel Offers { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>The properties.</value>        public ObservableCollection<PropertyViewModel> Properties        {            get { return this.properties; }            set { this.SetProperty(ref this.properties, value); }        }

        /// <summary>
        /// Gets the table selection command.
        /// </summary>
        /// <value>The table selection command.</value>        public DelegateCommand<string> TableSelectionCommand => new DelegateCommand<string>(this.TableSelection)
          .ObservesProperty(() => this.ActiveTabData)
          .ObservesProperty(() => this.ActiveTabTitle);
        
        /// <summary>
        /// Gets the tap command.
        /// </summary>
        /// <value>The tap command.</value>
        public DelegateCommand<string> ImageTapCommand => new DelegateCommand<string>(this.NavigateToEventsWebView);
        public DelegateCommand OfferTapCommand => new DelegateCommand(this.NavigateToOffersView);


        /// <summary>
        /// Ons the navigated to.
        /// </summary>
        /// <param name="parameters">Parameters.</param>        public override void OnNavigatedTo(NavigationParameters parameters)        {            base.OnNavigatedTo(parameters);        }

		/// <summary>
		/// Navigates to events web view.
		/// </summary>
		/// <param name="param">Parameter.</param>
		private void NavigateToEventsWebView(string param)
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("Content", param);
            this.navigationService.NavigateAsync("EventsDetailsPage", navigationParams, false, true);
        }


        private void NavigateToOffersView()
		{
			var navigationParams = new NavigationParameters();
			navigationParams.Add("Title", "Exclusive Offer");
			this.navigationService.NavigateAsync("BlankPage", navigationParams, false, true);
		}

        /// <summary>
        /// Loads the property.
        /// </summary>
        /// <returns>The property.</returns>        private async Task LoadProperty()        {
            var result =                await this.propertyFacade.GetLeasesByUserId(Mapper.Map<AuthorizedFacadeRequestModel>(this.keychainService.GetAuthorizedKeychainRequestModel()));            if (result.StatusCode == HttpStatusCode.OK)            {                Device.BeginInvokeOnMainThread(() => { this.ReloadPropertyCarousel(result.Content.Leases); });            }            else            {                await this.DialogService.DisplayAlertAsync(                    GrosvenorConstants.ApiCallErrorMessageTitle,                    Constants.LeaseErrorMessage,                    GrosvenorConstants.ApiCallErrorMessageOkButton);            }        }

        /// <summary>
        /// Loads the stories.
        /// </summary>
        /// <returns>The stories.</returns>
        /// <param name="type">Type.</param>        private async Task LoadStories(string type)        {            var tokens = this.keychainService.GetAuthorizedKeychainRequestModel();            var requestModel =                new AuthorizedPaginatedFacadeRequestModel                {                    AccessToken = tokens.AccessToken,                    RefreshToken = tokens.RefreshToken,                    Paging = new PaginationConfigModel { PageToGet = 1, NumberItems = 4 },                    QueryParameters = new List<KeyValuePair<string, object>>                                              {                                                  new KeyValuePair<string, object>(MagicStrings.StoryTypes, type),                    new KeyValuePair<string, object>(MagicStrings.FilterByLocation, false)                                              }                };            var result = await this.storyFacade.GetStories(requestModel);            if (result.StatusCode == HttpStatusCode.OK)            {                Device.BeginInvokeOnMainThread(() =>                {                    this.ReloadStories(type, result.Content.Stories);                });            }            else            {                await this.DialogService.DisplayAlertAsync(GrosvenorConstants.ApiCallErrorMessageTitle, Constants.LeaseErrorMessage, GrosvenorConstants.ApiCallErrorMessageOkButton);            }        }

        /// <summary>
        /// Reloads the stories.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="contentStories">Content stories.</param>        private void ReloadStories(string type, List<Story> contentStories)        {            if (type == "story")            {
                this.Communities.Clear();
                this.ActiveTabData.Clear();
                foreach (var story in contentStories)
                {
                    var storyViewModel = Mapper.Map<StoryViewModel>(story);
                    storyViewModel.ImageTapCommand = this.ImageTapCommand;
                    this.Communities.Add(storyViewModel);
                    this.ActiveTabData.Add(storyViewModel);
                }            }            else if (type == "event")
            {
                this.Events.Clear();
                foreach (var story in contentStories)                {
                    var storyViewModel = Mapper.Map<StoryViewModel>(story);
                    storyViewModel.ImageTapCommand = this.ImageTapCommand;
                    this.Events.Add(storyViewModel);                }            }        }

        /// <summary>
        /// Populates the fake properties.
        /// </summary>        private void PopulateFakeProperties()        {            this.Offers = new OfferViewModel            {                Title = "Fine Dining at Maze Grill",                Description = "Maze Grill by Gordon Ramsay are offering Grosvenor Connect diners 10% off in June",                ImageURL = "http://www.grosvenor.com/getattachment/Home/Carousel/Grosvenor-Europe-awarded-Green-Stars-for-sustainab/Belgravia-aerial-carousel.jpg"            };        }

        /// <summary>
        /// Reloads the property carousel.
        /// </summary>
        /// <param name="leases">Leases.</param>        private void ReloadPropertyCarousel(List<LeaseOverview> leases)        {            if (leases == null || leases.Count == 0) return;            this.Properties.Clear();            foreach (var lease in leases)            {                var mappedLease = Mapper.Map<PropertyViewModel>(lease);                this.Properties.Add(mappedLease);            }        }

        /// <summary>
        /// Tables the selection.
        /// </summary>
        /// <param name="parameter">Parameter.</param>        private void TableSelection(string parameter)        {
            this.ActiveTabData.Clear();            if (parameter == "My Community")            {
                foreach (var item in this.Communities)
                {
                    this.ActiveTabData.Add(item);
                }
                this.ActiveTabTitle = "My Community";            }            if (parameter == "Events")            {                this.ActiveTabTitle = "Events";
                foreach (var item in this.Events)
                {
                    this.ActiveTabData.Add(item);
                }            }        }    }}