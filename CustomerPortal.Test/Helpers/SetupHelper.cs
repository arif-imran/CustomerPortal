// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SetupHelper.cs" company="Grosvenor">
// //   
// // </copyright>
// // <summary>
// //   SetupHelper
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using System.Diagnostics.Contracts;
using AutoMapper;
using CustomerPortal.Common;
using CustomerPortal.DataAccess.ApiWrapper;
using CustomerPortal.DataAccess.ApiWrapper.Fakes;
using CustomerPortal.DataAccess.Model;
using CustomerPortal.DataAccess.Services;
using CustomerPortal.Facade.Facades;
using CustomerPortal.Facade.Fakes;
using CustomerPortal.Facade.Models;
using CustomerPortalApp.ViewModels;
using Grosvenor.Mobile.DataAccess.Model;
using Grosvenor.Mobile.DataAccess.Services;
using Microsoft.Practices.Unity;
using Prism.Common;
using Prism.Logging;
using Prism.Navigation;
using Prism.Services;

namespace CustomerPortal.Test
{
    public static class SetupHelper
    {
		private static bool allowInitialize = true;

		public static IUnityContainer InitializeContainer(this IUnityContainer container)
        {
            container.RegisterType<IDatabaseConnectionService, DatabaseConnectionServiceFake>(new ContainerControlledLifetimeManager());
            container.RegisterType<IDataAccessService, DataAccessService>(new ContainerControlledLifetimeManager());

            container.RegisterType<IKeychainService, KeychainServiceFake>(new ContainerControlledLifetimeManager());
            container.RegisterType<ILoggerFacade, EmptyLogger>();

            container.RegisterType<IAuthenticationApiWrapper, FakeAuthenticationApiWrapper>(new ContainerControlledLifetimeManager());
            container.RegisterType<ILogApiWrapper, FakeLogApiWrapper>(new ContainerControlledLifetimeManager());
            container.RegisterType<IAuthenticationHelperWrapper, FakeAuthenticationHelperWrapper>(new ContainerControlledLifetimeManager());
            container.RegisterType<IAccountApiWrapper, FakeAccountApiWrapper>(new ContainerControlledLifetimeManager());
            container.RegisterType<IPropertyApiWrapper, FakePropertyApiWrapper>(new ContainerControlledLifetimeManager());
            container.RegisterType<IStoryApiWrapper, FakeStoryApiWrapper>(new ContainerControlledLifetimeManager());

            container.RegisterType<IStoryFacade, StoryFacade>();
            container.RegisterType<IAccountFacade, AccountFacade>();
            container.RegisterType<IPropertyFacade, PropertyFacade>();
            container.RegisterType<ISettingsFacade, SettingsFacade>();
            container.RegisterType<IAuthenticationFacade, AuthenticationFacade>();

            container.RegisterType<IApplicationProvider, ApplicationProviderMock>();

            var para = new InjectionConstructor("OK", container.Resolve<IApplicationProvider>());
            container.RegisterType<IPageDialogService, PageDialogServiceMock>(para);
            container.RegisterType<INavigationService, NavigationServiceMock>();

            return container;
        }

        public static void InitializeMapper()
        {
			if (allowInitialize)
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
					mapConfig.CreateMap<CustomerPortal.DataAccess.Model.AccountStatementEntry, Facade.Models.AccountStatementEntry>();

					mapConfig.CreateMap<CustomerPortal.Facade.Models.CurrentBalance, StatementsViewModel>();
					mapConfig.CreateMap<Facade.Models.AccountStatementEntry, StatementsViewModel>()
					.ForMember(x => x.DueDate, (obj) => obj.MapFrom(x => x.Date.ToString(SharedConfig.ShortDateFormat)));
				});
				allowInitialize = false;
			}
        }
		public static IKeychainService CreateFakeKeyChain(this IUnityContainer container)
		{
			var key = container.Resolve<IKeychainService>();
			key.SaveCredentials(new KeychainModel()
			{
				Username = "fake",
				Password = "fake",
				AccessToken = "fake",
				RefreshToken = "fake",
				AccessTokenExpireDate = DateTime.Now.AddMinutes(20),
				UserId = Guid.NewGuid()
			});
			return key;
		}
    }
}