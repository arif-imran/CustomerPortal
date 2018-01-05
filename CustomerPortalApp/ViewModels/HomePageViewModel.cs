// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HomePageViewModel.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   HomePageViewModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Services;
using System.Windows.Input;
using Grosvenor.Mobile.Common;
using CustomerPortal.Facade.Facades;

namespace CustomerPortalApp.ViewModels
{
    using Grosvenor.Mobile.Common.Utils;

    /// <summary>
    /// Home page view model.
    /// </summary>
    public class HomePageViewModel : NavigationBaseViewModel
    {
        readonly INavigationService navigationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CustomerPortalApp.ViewModels.HomePageViewModel"/> class.
        /// </summary>
        /// <param name="dialogService">Dialog service.</param>
        /// <param name="navigationService">Navigation service.</param>
        public HomePageViewModel(IPageDialogService dialogService, INavigationService navigationService, IAuthenticationFacade authenticationFacade) : base(dialogService, authenticationFacade)
        {
            this.navigationService = navigationService;
            this.Title = "Home Page";
            this.AccountCommand = new DelegateCommand(this.AccountCommandAction);
        }

        public ICommand AccountCommand { get; set; }


        void AccountCommandAction()
        {
            this.navigationService.NavigateAsync("MainMasterDetailPage/Navigation/HomePage/AccountPage").Forget();
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
    }
}
