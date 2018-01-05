// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MainMenuPageViewModel.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   MainMenuPageViewModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Services;
using CustomerPortal.Facade;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using CustomerPortal.Common;
using System.Windows.Input;
using Grosvenor.Mobile.Common;
using CustomerPortal.Facade.Facades;
using Grosvenor.Mobile.DataAccess.Services;

namespace CustomerPortalApp.ViewModels
{
    using Grosvenor.Mobile.Common.Utils;

    /// <summary>
	/// Main menu page view model.
	/// </summary>
	public class MainMenuPageViewModel : NavigationBaseViewModel
	{
		/// <summary>
		/// The navigation service.
		/// </summary>
		readonly INavigationService navigationService;

		/// <summary>
		/// The KeyChain Service.
		/// </summary>
		readonly IKeychainService keychainService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CustomerPortalApp.ViewModels.MainMenuPageViewModel"/> class.
        /// </summary>
        /// <param name="dialogService">Dialog service.</param>
        /// <param name="navigationService">Navigation service.</param>
        /// <param name="authenticationFacade">Authentication facade.</param>
        public MainMenuPageViewModel(IPageDialogService dialogService,
                         INavigationService navigationService,
                         IAuthenticationFacade authenticationFacade,
                         IKeychainService keychainService) : base(dialogService, authenticationFacade, navigationService)
        {
            this.navigationService = navigationService;
            this.keychainService = keychainService;

            this.LogoutCommand = new DelegateCommand(() => { this.ExecuteAsyncTask(this.LogoutAction).Forget(); });
            this.MyProfileCommand = new DelegateCommand(() =>
            {
                this.ExecuteAsyncTask(this.NavigateToProfilePage).Forget();
            });
        }

		/// <summary>
		/// Gets or sets the logout command.
		/// </summary>
		/// <value>The logout command.</value>
		public ICommand LogoutCommand { get; set; }
		public ICommand MyProfileCommand { get; set; }


		private string username;
		public string Username
		{
			get
			{
                return this.keychainService.GetCredentials().Username;
			}
		}


		/// <summary>
		/// Logout the action.
		/// </summary>
		/// <returns>The action.</returns>
		private async Task LogoutAction()
		{
			var resutl = await this.DialogService.DisplayAlertAsync(Constants.LogoutMessageTitle, Constants.LogoutMessage, Constants.LogoutMessageConfirm, Constants.LogoutMessageCancel);

			if (resutl)
			{
				// Delete Credentials from Keychain/Keystore
				this.keychainService.DeleteCredentials();
				this.AuthenticationFacade.Logout();
				await this.navigationService.NavigateAsync("LoginPage");
			}
		}

        private async Task NavigateToProfilePage(){

           await this.navigationService.NavigateAsync("Navigation/ProfilePage");
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
	}
}
