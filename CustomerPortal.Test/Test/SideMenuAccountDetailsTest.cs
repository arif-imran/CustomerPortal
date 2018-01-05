using System;
using System.Threading.Tasks;
using CustomerPortal.Common;
using CustomerPortal.Facade.Facades;
using CustomerPortalApp.ViewModels;
using Microsoft.Practices.Unity;
using Prism.Navigation;
using Prism.Services;
using Xunit;

namespace CustomerPortal.Test.Test
{
	public class SideMenuAccountDetailsTest
	{
		IUnityContainer container = new UnityContainer();

		public SideMenuAccountDetailsTest()
		{
			container.InitializeContainer();

			SetupHelper.InitializeMapper();
		}

		/// <summary>
		/// Sides the menu should check if the account details has been loaded pass.
		/// </summary>
		/// <returns>The menu should check if the account details has been loaded pass.</returns>
		[Fact]
		public async Task SideMenu_ShouldCheckIfTheAccountDetailsHasBeenLoaded_Pass()
		{
			//Arrange
			var navigationService = container.Resolve<INavigationService>();
			var authenticationFacade = container.Resolve<IAuthenticationFacade>();
			var dialogService = container.Resolve<IPageDialogService>();
			var propertyFacade = container.Resolve<IPropertyFacade>();
			var keychainService = SetupHelper.CreateFakeKeyChain(this.container);

			//Act
			var mainMenuPageViewModel = new MainMenuPageViewModel(dialogService, navigationService, authenticationFacade, keychainService);

			await Task.Delay(2000);

			//Assert
			Assert.Equal(mainMenuPageViewModel.Username, keychainService.GetCredentials().Username);

		}
	}
}