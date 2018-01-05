using Prism.Unity;
using CustomerPortalApp.Views;
using Microsoft.Practices.Unity;
using CustomerPortal.DataAccess;
using CustomerPortal.DataAccess.ApiWrapper;
using CustomerPortal.Facade;
using CustomerPortal.Facade.Facades;
using CustomerPortal.Facade.Helpers;
using CustomerPortalApp.ViewModels;
using CustomerPortalApp.Interfaces;
using AutoMapper;
using CustomerPortal.Facade.Models;
using CustomerPortal.DataAccess.Model;

namespace CustomerPortalApp
{
    using CustomerPortal.Common;
    using CustomerPortal.DataAccess.ApiWrapper.Fakes;
    using CustomerPortal.DataAccess.Services;
    using CustomerPortal.Facade.Fakes;

    using Grosvenor.Mobile.DataAccess.Model;
    using Grosvenor.Mobile.DataAccess.Services;
    using Xamarin.Forms;
    using AccountStatementEntry = CustomerPortal.Facade.Models.AccountStatementEntry;

    public partial class App : PrismApplication
    {
        static public int ScreenWidth;
        public static string AppName { get { return "StoreAccountInfo"; } } //needs to be change
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            InitializeMapper();

            NavigationService.NavigateAsync("ExtendedLoadingPage");

            var lifecycleService = UnityContainerExtensions.Resolve<ILifecycleService>(this.Container);
            lifecycleService.StartAsync(this.NavigationService);
            SetResources();
        }

        /// <summary>
        /// Ons the resume.
        /// </summary>
        protected override void OnResume()
        {
            base.OnResume();
			var lifecycleService = UnityContainerExtensions.Resolve<ILifecycleService>(this.Container);
            lifecycleService.StartOnResume(this.NavigationService);
        }
      
        private void SetResources()
        {
            var width = Xamarin.Forms.DependencyService.Get<ICommonUtility>().ScreenWidth();
            var height = Xamarin.Forms.DependencyService.Get<ICommonUtility>().ScreenHeight();
            this.Resources.Add("ScreenHeight", height);
            this.Resources.Add("OneThirdScreenHeight", height / 3);
            this.Resources.Add("OneForthScreenHeight", height / 4);
            this.Resources.Add("TwoThirdScreenHeight", height * 0.6);
            this.Resources.Add("OneFifthScreenHeight", (height * 0.6) / 2.3);
            this.Resources.Add("OneEightScreenHeight", (height * 0.6) / 3);
            this.Resources.Add("HalfScreenWidth", width / 2);
            var gridViewSpacing = width / 16;
            this.Resources.Add("GridViewSpacing", gridViewSpacing / 2);
            this.Resources.Add("HalfScreenWithSpacing", (width / 2) - gridViewSpacing);
        }
        protected override void RegisterTypes()
        {

            this.Container.RegisterType<IDataAccessService, DataAccessService>(new ContainerControlledLifetimeManager());
            this.Container.RegisterType<ILifecycleService, LifecycleService>(new ContainerControlledLifetimeManager());
#if FAKE
            this.Container.RegisterType<IAuthenticationApiWrapper, FakeAuthenticationApiWrapper>();
            this.Container.RegisterType<ILogApiWrapper, FakeLogApiWrapper>();
            this.Container.RegisterType<IAuthenticationHelperWrapper, FakeAuthenticationHelperWrapper>();
            this.Container.RegisterType<IAccountApiWrapper, FakeAccountApiWrapper>();
            this.Container.RegisterType<IPropertyApiWrapper, FakePropertyApiWrapper>();
            this.Container.RegisterType<IStoryApiWrapper, FakeStoryApiWrapper>();
#else
            this.Container.RegisterType<IAuthenticationApiWrapper, AuthenticationApiWrapper>();
            this.Container.RegisterType<ILogApiWrapper, LogApiWrapper>();
            this.Container.RegisterType<IAuthenticationHelperWrapper, AuthenticationHelperWrapper>();
            this.Container.RegisterType<IAccountApiWrapper, AccountApiWrapper>();
            this.Container.RegisterType<IPropertyApiWrapper, PropertyApiWrapper>();
            this.Container.RegisterType<IStoryApiWrapper, StoryApiWrapper>();
#endif
            this.Container.RegisterType<IStoryFacade, StoryFacade>();
            this.Container.RegisterType<IAccountFacade, AccountFacade>();
            this.Container.RegisterType<IPropertyFacade, PropertyFacade>();
            this.Container.RegisterType<ISettingsFacade, SettingsFacade>(new ContainerControlledLifetimeManager());
            this.Container.RegisterType<IAuthenticationFacade, AuthenticationFacade>(new ContainerControlledLifetimeManager());

            Container.RegisterTypeForNavigation<ExtendedLoadingPage>();
            Container.RegisterTypeForNavigation<LoginPage>();
            Container.RegisterTypeForNavigation<HomePage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MainMenuPage>();
            Container.RegisterTypeForNavigation<NavigationPage>("Navigation");
            Container.RegisterTypeForNavigation<MainMasterDetailPage>();
            Container.RegisterTypeForNavigation<DashboardPage>();
            Container.RegisterTypeForNavigation<AccountPage>();
            Container.RegisterTypeForNavigation<ContactPage>();
            Container.RegisterTypeForNavigation<SupportPage>();
            Container.RegisterTypeForNavigation<ProfilePage>();
			Container.RegisterTypeForNavigation<PropertyDetailsPage>();
            Container.RegisterTypeForNavigation<AccountStatementsPage>();
            Container.RegisterTypeForNavigation<EventsDetailsPage>();
            Container.RegisterTypeForNavigation<BlankPage>();
        }

        private void InitializeMapper()
        {
            Mapper.Initialize(mapConfig =>
                {
                    mapConfig.CreateMap<LoginRequestModel, LoginApiRequestModel>();
                    mapConfig.CreateMap<LoginApiRequestModel, LoginRequestModel>();
                    mapConfig.CreateMap<MyProfileApiResponseModel, MyProfileResponseModel>();
                    mapConfig.CreateMap<MyProfileResponseModel, MyProfileApiResponseModel>();

                    mapConfig.CreateMap<LeaseOverview, PropertyViewModel>()
                        .ForSourceMember(x => x.FullLeaseAddress, (obj) => obj.Ignore());

                    mapConfig.CreateMap<AuthorizedKeychainRequestModel, AuthorizedFacadeRequestModel>();
                    mapConfig.CreateMap<CustomerPortal.Facade.Models.Story, StoryViewModel>();
                    mapConfig.CreateMap<CustomerPortal.DataAccess.Model.AccountStatementEntry, AccountStatementEntry>();

                    mapConfig.CreateMap<CustomerPortal.Facade.Models.CurrentBalance, StatementsViewModel>();
                    mapConfig.CreateMap<AccountStatementEntry, StatementsViewModel>()
                    .ForMember(x => x.DueDate, (obj) => obj.MapFrom(x => x.Date.ToString(SharedConfig.ShortDateFormat)));
                });
        }
    }
}