using System;
using System.Threading.Tasks;
using CustomerPortal.Common;
using CustomerPortal.Facade.Facades;
using CustomerPortalApp;
using CustomerPortalApp.ViewModels;
using Microsoft.Practices.Unity;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using Xunit;

namespace CustomerPortal.Test.Test
{
	public class AccountTabPageTest
	{
		/// <summary>
		/// The container.
		/// </summary>
		IUnityContainer container = new UnityContainer();
		/// <summary>
		/// Initializes a new instance of the <see cref="T:CustomerPortal.Test.Test.AccountTabPageTest"/> class.
		/// </summary>
		public AccountTabPageTest()
		{
			this.container.InitializeContainer();
			SetupHelper.InitializeMapper();
		}

		/// <summary>
		/// Accounts the tab should check if the property has been loaded pass.
		/// </summary>
		/// <returns>The tab should check if the property has been loaded pass.</returns>
		[Fact]
		public async Task AccountTab_ShouldCheckIfThePropertyHasBeenLoaded_Pass()
		{
			//Arrange
			AccountPageViewModel accountPageViewModel =
				new AccountPageViewModel(this.container.Resolve<IPageDialogService>(),
										this.container.Resolve<IAuthenticationFacade>(),
										this.container.Resolve<INavigationService>(),
										this.container.Resolve<IPropertyFacade>(),
										SetupHelper.CreateFakeKeyChain(this.container));

			await Task.Delay(2000);

			//Assert
			Assert.Equal(accountPageViewModel.Properties.Count, 24);

		}

		/// <summary>
		/// Accounts the tab navigations has been loaded pass.
		/// </summary>
		/// <returns>The tab navigations has been loaded pass.</returns>
		[Fact]
		public async Task AccountTab_NavigationsHasBeenLoaded_Pass()
		{
			//Arrange
			AccountPageViewModel accountPageViewModel =
				new AccountPageViewModel(this.container.Resolve<IPageDialogService>(),
										this.container.Resolve<IAuthenticationFacade>(),
										this.container.Resolve<INavigationService>(),
										this.container.Resolve<IPropertyFacade>(),
										SetupHelper.CreateFakeKeyChain(this.container));

			await Task.Delay(2000);

			//Assert
			Assert.Equal(accountPageViewModel.Navigations.Count, 5);
		}

		/// <summary>
		/// Accounts the tab navigation check pass.
		/// </summary>
		/// <returns>The tab navigation check pass.</returns>
		[Fact]
		public async Task AccountTab_NavigationCheck_Pass()
		{
			var navigationService = this.container.Resolve<INavigationService>();
			//Arrange
			AccountPageViewModel accountPageViewModel =
				new AccountPageViewModel(this.container.Resolve<IPageDialogService>(),
										this.container.Resolve<IAuthenticationFacade>(),
										navigationService,
										this.container.Resolve<IPropertyFacade>(),
										SetupHelper.CreateFakeKeyChain(this.container));

			await Task.Delay(2000);


			accountPageViewModel.ItemTappedCommand.Execute(new NavigationItemViewModel()
			{
				Name = "Property Details",
				NavigationUrl = "PropertyDetailsPage",
				ItemTappedCommand = new DelegateCommand<NavigationItemViewModel>((nav) =>
				{
					nav.LeaseId = new Guid("af32a4fb-ec71-4f94-a2d6-0005a9b6e2f2");

					var navigationParams = new NavigationParameters();

					navigationParams.Add(MagicStrings.Lease, accountPageViewModel.SelectedProperty);

					navigationService.NavigateAsync(nav.NavigationUrl, navigationParams, false, true);
				})
			});

			var navigation = navigationService as NavigationServiceMock;
			Assert.NotNull(navigation);

			var navUrl = navigation.LastNavigationUrl;
			//Assert
			Assert.Equal(navUrl, "PropertyDetailsPage");
		}

	}
}
