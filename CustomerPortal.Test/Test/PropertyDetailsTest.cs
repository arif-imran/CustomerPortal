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
	public class PropertyDetailsTest
	{
		IUnityContainer container = new UnityContainer();

		public PropertyDetailsTest()
		{
			container.InitializeContainer();
			Xamarin.Forms.Mocks.MockForms.Init();
			SetupHelper.InitializeMapper();
		}

		/// <summary>
		/// Shoulds the check if the property details has been loaded.
		/// </summary>
		/// <returns>The check if the property details has been loaded.</returns>
		[Fact]
		public async Task PropertyDetails_ShouldCheckIfThePropertyDetailsHasBeenLoaded_Pass()
		{
			//Arrange
			var navigationService = container.Resolve<INavigationService>();
			var authenticationFacade = container.Resolve<IAuthenticationFacade>();
			var dialogService = container.Resolve<IPageDialogService>();
			var propertyFacade = container.Resolve<IPropertyFacade>();
			var keychainService = SetupHelper.CreateFakeKeyChain(this.container);

			//Arrange
			NavigationParameters navigationParams = new NavigationParameters();
			PropertyViewModel propertyViewModel = new PropertyViewModel()
			{
				AccountBalance = 22.5,
				HasMaintenance = false,
				LeaseAccountNumber = "t0002727",
				LeaseAddress = "Park Lane 10 Windows in Nth Wall of Dorcheste",
				LeaseId = new Guid("af32a4fb-ec71-4f94-a2d6-0005a9b6e2f2"),
				LeasePropertyId = new Guid("e5d8800d-02e3-4a0b-ac12-ed9ab04900e7"),
				LeaseUnit = "Park Lane 10 Windows in Nth Wall of Dorcheste",
				NumberOfJobs = 0
			};

			navigationParams.Add(MagicStrings.Lease, propertyViewModel);

			var propertyDetailsPageViewModel = new PropertyDetailsPageViewModel(dialogService, authenticationFacade, propertyFacade, keychainService, navigationService);

			//Act
			propertyDetailsPageViewModel.OnNavigatedTo(navigationParams);

			await Task.Delay(2000);

			//Assert
			Assert.Equal(propertyDetailsPageViewModel.AccountNumber, "t0002727");
			Assert.Equal(propertyDetailsPageViewModel.Rent, 10);
			Assert.Equal(propertyDetailsPageViewModel.Street, "Hotel -10, Paris South, France, 1234 343, France");

		}
	}
}
