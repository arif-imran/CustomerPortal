using System;
using System.Threading.Tasks;
using CustomerPortal.Facade.Facades;
using CustomerPortalApp.ViewModels;
using Microsoft.Practices.Unity;
using Prism.Services;
using Xunit;

namespace CustomerPortal.Test.Test
{
	public class SupportTabTest
	{
		IUnityContainer container = new UnityContainer();
		public SupportTabTest()
		{
			container.InitializeContainer();

			SetupHelper.InitializeMapper();
		}

		/// <summary>
		/// Supports the tab should check if the data has been loaded pass.
		/// </summary>
		/// <returns>The tab should check if the data has been loaded pass.</returns>
		[Fact]
		public async Task SupportTab_ShouldCheckIfTheDataHasBeenLoaded_Pass()
		{
			//Arrange
			var authenticationFacade = container.Resolve<IAuthenticationFacade>();
			var dialogService = container.Resolve<IPageDialogService>();

			//Act
			var supportPageViewModel = new SupportPageViewModel(dialogService, authenticationFacade);

			await Task.Delay(2000);

			//Assert
			Assert.Equal(supportPageViewModel.Title, "Support Page");
			Assert.Equal(supportPageViewModel.FAQItems.Count, 5);
			Assert.Equal(supportPageViewModel.FAQSections.Count, 9);
		}
	}
}

