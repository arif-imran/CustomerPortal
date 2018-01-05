// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MainNavigationPageViewModel.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   MainNavigationPageViewModel
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

namespace CustomerPortalApp.ViewModels
{
    /// <summary>
    /// Main navigation page view model.
    /// </summary>
    public class MainNavigationPageViewModel : NavigationBaseViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:CustomerPortalApp.ViewModels.MainNavigationPageViewModel"/> class.
        /// </summary>
        /// <param name="dialogService">Dialog service.</param>
        /// <param name="authenticationFacade">Authentication facade.</param>
        public MainNavigationPageViewModel(IPageDialogService dialogService, IAuthenticationFacade authenticationFacade, INavigationService navigationService) 
            : base(dialogService, authenticationFacade, navigationService)
        {
        }
    }
}
