// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MasterDetailPage.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   MasterDetailPage
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Services;
using CustomerPortal.Facade.Facades;
using System.Windows.Input;
using Grosvenor.Mobile.DataAccess.Services;
using System.Threading.Tasks;
using CustomerPortal.Common;
using Grosvenor.Mobile.Common.Utils;

namespace CustomerPortalApp.ViewModels
{
    /// <summary>
    /// Main master detail page view model.
    /// </summary>
    public class MainMasterDetailPageViewModel : NavigationBaseViewModel
    {
        /// <summary>
        /// The keychain service.
        /// </summary>
        readonly IKeychainService keychainService;

        /// <summary>
        /// The navigation service.
        /// </summary>
        readonly INavigationService navigationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CustomerPortalApp.ViewModels.MainMasterDetailPageViewModel"/> class.
        /// </summary>
        /// <param name="dialogService">Dialog service.</param>
        /// <param name="authenticationFacade">Authentication facade.</param>
        /// <param name="navigationService">Navigation service.</param>
        public MainMasterDetailPageViewModel(IPageDialogService dialogService, 
                                             IAuthenticationFacade authenticationFacade, 
                                             INavigationService navigationService, 
                                            IKeychainService keychainService)
            : base(dialogService, authenticationFacade, navigationService)
        {
            this.navigationService = navigationService;
            this.keychainService = keychainService;

            this.LogoutCommand = new DelegateCommand(() => { this.ExecuteAsyncTask(this.LogoutAction).Forget(); });

            this.NavigationCommand = new DelegateCommand<string>((page) =>
            {
                navigationService.NavigateAsync(page);
            });
        }

        /// <summary>
        /// Gets or sets the logout command.
        /// </summary>
        /// <value>The logout command.</value>
        public ICommand LogoutCommand { get; set; }

        /// <summary>
        /// Gets or sets my profile command.
        /// </summary>
        /// <value>My profile command.</value>
        public ICommand NavigationCommand { get; set; }

        private string username;
        public string Username
        {
            get
            {
                return this.keychainService.GetCredentials().Username;
            }
        }

        /// <summary>
        /// Ons the navigated to.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
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
    }
}
