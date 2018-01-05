// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DashboardPageViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   Dashboard page view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortalApp.ViewModels
    using Grosvenor.Mobile.DataAccess.Services;

    /// <summary>
    public class DashboardPageViewModel : NavigationBaseViewModel
        /// <summary>
        /// The property facade.
        /// </summary>
        private readonly IPropertyFacade propertyFacade;

        /// <summary>
        /// The settings facade.
        /// </summary>


        /// <summary>
        /// The story facade.
        /// </summary>

        /// <summary>
        /// The active tab data.
        /// </summary>

        /// <summary>
        /// The active tab title.
        /// </summary>

        /// <summary>
        /// The properties.
        /// </summary>

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
        /// <param name="keychainService">Keychain service.</param>
          IPageDialogService dialogService,
          IAuthenticationFacade authenticationFacade,
          ISettingsFacade settingsFacade,
            INavigationService navigationService,
          IPropertyFacade propertyFacade,
          IStoryFacade storyFacade,
            IKeychainService keychainService)
          : base(dialogService, authenticationFacade)
            this.keychainService = keychainService;
            this.settingsFacade = settingsFacade;

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

            PopulateFakeProperties();

        /// <summary>
        /// Gets or sets the active tab data.
        /// </summary>
        /// <value>The active tab data.</value>

        /// <summary>
        /// Gets or sets the active tab title.
        /// </summary>
        /// <value>The active tab title.</value>

        /// <summary>
        /// Gets or sets the communities.
        /// </summary>
        /// <value>The communities.</value>

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        /// <value>The events.</value>

        /// <summary>
        /// Gets or sets the offers.
        /// </summary>
        /// <value>The offers.</value>

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>The properties.</value>

        /// <summary>
        /// Gets the table selection command.
        /// </summary>
        /// <value>The table selection command.</value>
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
        /// <param name="parameters">Parameters.</param>

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
        /// <returns>The property.</returns>


        /// <summary>
        /// Loads the stories.
        /// </summary>
        /// <returns>The stories.</returns>
        /// <param name="type">Type.</param>

        /// <summary>
        /// Reloads the stories.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="contentStories">Content stories.</param>
                this.Communities.Clear();
                this.ActiveTabData.Clear();
                foreach (var story in contentStories)
                {
                    var storyViewModel = Mapper.Map<StoryViewModel>(story);
                    storyViewModel.ImageTapCommand = this.ImageTapCommand;
                    this.Communities.Add(storyViewModel);
                    this.ActiveTabData.Add(storyViewModel);
                }
            {
                this.Events.Clear();
                foreach (var story in contentStories)
                    var storyViewModel = Mapper.Map<StoryViewModel>(story);
                    storyViewModel.ImageTapCommand = this.ImageTapCommand;
                    this.Events.Add(storyViewModel);

        /// <summary>
        /// Populates the fake properties.
        /// </summary>

        /// <summary>
        /// Reloads the property carousel.
        /// </summary>
        /// <param name="leases">Leases.</param>

        /// <summary>
        /// Tables the selection.
        /// </summary>
        /// <param name="parameter">Parameter.</param>
            this.ActiveTabData.Clear();
                foreach (var item in this.Communities)
                {
                    this.ActiveTabData.Add(item);
                }

                foreach (var item in this.Events)
                {
                    this.ActiveTabData.Add(item);
                }