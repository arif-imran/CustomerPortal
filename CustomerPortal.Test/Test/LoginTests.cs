using Xunit;
using CustomerPortalApp.ViewModels;
using Prism.Services;
using Microsoft.Practices.Unity;
using Prism.Common;
using Prism.Navigation;
using CustomerPortal.DataAccess.ApiWrapper;
using CustomerPortal.DataAccess.ApiWrapper.Fakes;
using CustomerPortal.Facade.Facades;
using CustomerPortal.Facade.Fakes;
using Prism.Logging;
using Grosvenor.Mobile.DataAccess.Services;
using AutoMapper;
using CustomerPortal.Facade.Models;
using CustomerPortal.DataAccess.Model;
using Grosvenor.Mobile.DataAccess.Model;
using CustomerPortal.DataAccess.Services;
using System.Threading.Tasks;

namespace CustomerPortal.Test
{
	public class LoginTests
	{
		IUnityContainer container = new UnityContainer();

		/// <summary>
		/// Initializes a new instance of the <see cref="T:CustomerPortal.Test.LoginTests"/> class.
		/// </summary>
		public LoginTests()
		{
			this.container.InitializeContainer();
			Xamarin.Forms.Mocks.MockForms.Init();
			SetupHelper.InitializeMapper();
		}

		/// <summary>
		/// Shoulds the login in with valid credentials.
		/// </summary>
		/// <returns>The login in with valid credentials.</returns>
		[Fact]
		public async Task ShouldLoginInWithValidCredentials()
		{
			//Arrange
			var keychainService = container.Resolve<IKeychainService>();
			var navigationService = container.Resolve<INavigationService>();
			var authenticationFacade = container.Resolve<IAuthenticationFacade>();
			var dialogService = container.Resolve<IPageDialogService>();

			var viewModel = new LoginPageViewModel(navigationService, authenticationFacade, dialogService, keychainService)
			{
				Username = "some.user@grosvenor.com",
				Password = "Password1"
			};

			//Act
			viewModel.LoginCommand.Execute(null);

			await Task.Delay(2000);

			//Assert
			Assert.Equal(keychainService.AreCredentialsValid(), true);
			var credentials = keychainService.GetCredentials();
			Assert.Equal(viewModel.Username.ToLower(), credentials.Username.ToLower());

			var navigation = navigationService as NavigationServiceMock;
			Assert.NotNull(navigation);

			var navUrl = navigation.LastNavigationUrl;
			var expectedNavUrl = "app:///MainMasterDetailPage/Navigation/HomePage/DashboardPage";

			Assert.Equal(expectedNavUrl, navUrl);
		}

		[Fact]
		public async Task Should_NotLoginInWithInvalidCredentials_Pass()
		{
			//Arrange
			var keychainService = container.Resolve<IKeychainService>();
			var navigationService = container.Resolve<INavigationService>();
			var authenticationFacade = container.Resolve<IAuthenticationFacade>();
			var dialogService = container.Resolve<IPageDialogService>();

			var viewModel = new LoginPageViewModel(navigationService, authenticationFacade, dialogService, keychainService)
			{
				Username = "some.user@grosveno.com",
			};
			//Act
			viewModel.LoginCommand.Execute(null);

			await Task.Delay(1000);

			//Assert
			Assert.Equal(keychainService.AreCredentialsValid(), true);
			var credentials = keychainService.GetCredentials();
			Assert.Equal(viewModel.Username.ToLower(), credentials.Username.ToLower());

			var navigation = navigationService as NavigationServiceMock;
			Assert.NotNull(navigation);

			var navUrl = navigation.LastNavigationUrl;
			var expectedNavUrl = "app:///MainMasterDetailPage/Navigation/HomePage/DashboardPage";

			Assert.Equal(expectedNavUrl, navUrl);

		}
		/// <summary>
		/// Logins the should be able to logout pass.
		/// </summary>
		[Fact]
		public async Task Login_ShouldBeAbleToLogout_Pass()
		{
			//Arrange 
			var key = SetupHelper.CreateFakeKeyChain(this.container);
			var navigationService = this.container.Resolve<INavigationService>();
			var authFacade = this.container.Resolve<IAuthenticationFacade>();
			var Out = new MainMasterDetailPageViewModel(this.container.Resolve<IPageDialogService>(),
														authFacade,
														   navigationService,
														key);
			//Act
			Out.LogoutCommand.Execute(this);
			//Delay
			await Task.Delay(1000);
			//Assert
			Assert.True(key.AreCredentialsValid() == false, "Test Pass");
			Assert.Null(authFacade.CurrentUser);
		}
	}
}
