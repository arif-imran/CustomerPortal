﻿using System;
using Xunit;
using CustomerPortalApp.ViewModels;
using Prism.Services;
using Microsoft.Practices.Unity;
using Prism.Common;
using CustomerPortalApp.Views;
using CustomerPortal.Facade.Facades;
using Prism.Navigation;
using Grosvenor.Mobile.DataAccess.Services;
using System.Threading.Tasks;
using Grosvenor.Mobile.DataAccess.Model;

namespace CustomerPortal.Test
{

	public class DashboardTests
	{
		IUnityContainer container = new UnityContainer();


		/// <summary>
		/// Initializes a new instance of the <see cref="T:CustomerPortal.Test.DashboardTests"/> class.
		/// </summary>
		public DashboardTests()
		{
			this.container.InitializeContainer();
            Xamarin.Forms.Mocks.MockForms.Init();
			SetupHelper.InitializeMapper();
		}


		/// <summary>
		/// Should check if the offers have been loaded
		/// </summary>
		/// <returns>The offers populated by the fake.</returns>
		[Fact]
		public async Task DashBoard_ShouldCheckIfTheDataHasBeenLoaded_Pass()
		{
			////Arrange
			DashboardPageViewModel vm;
			var key = SetupHelper.CreateFakeKeyChain(this.container);
			vm = new DashboardPageViewModel(
				this.container.Resolve<IPageDialogService>(),
				this.container.Resolve<IAuthenticationFacade>(),
				this.container.Resolve<SettingsFacade>(),
				this.container.Resolve<INavigationService>(),
				this.container.Resolve<IPropertyFacade>(),
				this.container.Resolve<IStoryFacade>(),
				key);
			await Task.Delay(2000);
			//Assert
			Assert.Equal(vm.Offers.Title, "Fine Dining at Maze Grill");
			Assert.Equal(24, vm.Properties.Count);
			Assert.Equal(4, vm.Communities.Count);
			Assert.Equal(2, vm.Events.Count);
		}

		/// <summary>
		/// Executing the tableselection command with my communities as input
		/// </summary>
		/// <returns>The ActiveTabData should be populated by the communities in fake.</returns>
		[Fact]
		public async Task DashBoard_TabSelectionCommunities_Pass()
		{
			////Arrange
			DashboardPageViewModel vm;
			var key = SetupHelper.CreateFakeKeyChain(this.container);
			vm = new DashboardPageViewModel(
				this.container.Resolve<IPageDialogService>(),
				this.container.Resolve<IAuthenticationFacade>(),
				this.container.Resolve<SettingsFacade>(),
				this.container.Resolve<INavigationService>(),
				this.container.Resolve<IPropertyFacade>(),
				this.container.Resolve<IStoryFacade>(),
				key);

			await Task.Delay(2000);
			vm.TableSelectionCommand.Execute("My Community");
			//Assert
			Assert.Equal(4, vm.ActiveTabData.Count);
		}
		/// <summary>
		/// Executing the tableselection command with my events as input
		/// </summary>
		/// <returns>The ActiveTabData should be populated by the events in fake.</returns>
		[Fact]
		public async Task DashBoard_TabSelectionEvents_Pass()
		{
			////Arrange
			DashboardPageViewModel vm;
			var key = SetupHelper.CreateFakeKeyChain(this.container);
			vm = new DashboardPageViewModel(
				this.container.Resolve<IPageDialogService>(),
				this.container.Resolve<IAuthenticationFacade>(),
				this.container.Resolve<SettingsFacade>(),
				this.container.Resolve<INavigationService>(),
				this.container.Resolve<IPropertyFacade>(),
				this.container.Resolve<IStoryFacade>(),
				key);

			await Task.Delay(2000);
			vm.TableSelectionCommand.Execute("Events");
			//Assert
			Assert.Equal(2, vm.ActiveTabData.Count);
		}
		/// <summary>
		/// Executing the OfferTapCommand command 
		/// </summary>
		/// <returns>The navigation should take place from homepage to blank page.</returns>
		[Fact]
		public async Task DashBoard_VerifyOfferNavigation_Pass()
		{
			////Arrange
			DashboardPageViewModel vm;
			var key = SetupHelper.CreateFakeKeyChain(this.container);
			var navigationService = this.container.Resolve<INavigationService>();
			vm = new DashboardPageViewModel(
				this.container.Resolve<IPageDialogService>(),
				this.container.Resolve<IAuthenticationFacade>(),
				this.container.Resolve<SettingsFacade>(),
				navigationService,
				this.container.Resolve<IPropertyFacade>(),
				this.container.Resolve<IStoryFacade>(),
				key);

			await Task.Delay(2000);
			vm.OfferTapCommand.Execute();
			var navigation = navigationService as NavigationServiceMock;
			Assert.NotNull(navigation);

            var navUrl = navigation.LastNavigationUrl;
			//Assert
			Assert.Equal(navUrl, "BlankPage");
		}
		/// <summary>
		/// Executing the ImageTapCommand command 
		/// </summary>
		/// <returns>The navigation should take place from homepage to web view page.</returns>
		[Fact]
		public async Task DashBoard_VerifyWebViewNavigation_Pass()
		{
			////Arrange
			DashboardPageViewModel vm;
			var key = SetupHelper.CreateFakeKeyChain(this.container);
			var navigationService = this.container.Resolve<INavigationService>();
			vm = new DashboardPageViewModel(
				this.container.Resolve<IPageDialogService>(),
				this.container.Resolve<IAuthenticationFacade>(),
				this.container.Resolve<SettingsFacade>(),
				navigationService,
				this.container.Resolve<IPropertyFacade>(),
				this.container.Resolve<IStoryFacade>(),
				key);

			await Task.Delay(2000);
			vm.ImageTapCommand.Execute("abcd");
			var navigation = navigationService as NavigationServiceMock;
			Assert.NotNull(navigation);

			var navUrl = navigation.LastNavigationUrl;
			//Assert
			Assert.Equal(navUrl, "EventsDetailsPage");
		}
	}
}
