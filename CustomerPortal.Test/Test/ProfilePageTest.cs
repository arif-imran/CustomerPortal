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

namespace CustomerPortal.Test.Test
{
	public class ProfilePageTest
	{
		readonly IUnityContainer container = new UnityContainer();

		/// <summary>
		/// Initializes a new instance of the <see cref="T:CustomerPortal.Test.LoginTests"/> class.
		/// </summary>
		public ProfilePageTest()
		{
			this.container.InitializeContainer();
			Xamarin.Forms.Mocks.MockForms.Init();
			SetupHelper.InitializeMapper();
		}

		/// <summary>
		/// Shoulds the check if the profile has been loaded.
		/// </summary>
		/// <returns>The check if the profile has been loaded.</returns>
		[Fact]
		public async Task ProfilePage_ShouldCheckIfTheProfileHasBeenLoaded_Pass()
		{
			//Arrange
			var keychainService = container.Resolve<IKeychainService>();
			var navigationService = container.Resolve<INavigationService>();
			var authenticationFacade = container.Resolve<IAuthenticationFacade>();
			var dialogService = container.Resolve<IPageDialogService>();
			var accountFacade = container.Resolve<IAccountFacade>();
			var keychain = SetupHelper.CreateFakeKeyChain(this.container);

			var ProfilePageViewModel = new ProfilePageViewModel(dialogService, authenticationFacade, accountFacade, keychain, navigationService);

			//Act
			ProfilePageViewModel.OnNavigatedTo(new NavigationParameters());

			// call account facade to get Profile Details.            
			var myProfile = await accountFacade.MyProfile(keychainService.GetAuthorizedKeychainRequestModel());
			var profile = myProfile?.Content?.MyProfile;

			await Task.Delay(2000);

			//Assert
			Assert.Equal(ProfilePageViewModel.Email, profile.EmailAddress);
			Assert.Equal(ProfilePageViewModel.FirstName, profile.FirstName);
			Assert.Equal(ProfilePageViewModel.LastName, profile.LastName);
			//Assert.Equal(ProfilePageViewModel, "laura.smith@grosvenor.co.uk");

		}
	}
}
