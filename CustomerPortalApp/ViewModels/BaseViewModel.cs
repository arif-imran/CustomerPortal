// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="BaseViewModel.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   BaseViewModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Commands;
using Prism.Navigation;

using System.Collections.Generic;
using System.Linq;
using Prism.Services;

using System.Diagnostics.Contracts;
using CustomerPortal.Common;
using CustomerPortalApp.Interfaces;
using CustomerPortal.Facade.Facades;

namespace CustomerPortalApp.ViewModels
{
    using System;
    using System.Threading.Tasks;
    using Grosvenor.Mobile.Forms.ViewModels;
    using Grosvenor.Mobile.Common;
    using Grosvenor.Mobile.Forms.ViewModels;

    using Prism.Mvvm;
    using Xamarin.Forms;

    public class BaseViewModel : GrosvenorBaseViewModel
    {
        

        protected IAuthenticationFacade AuthenticationFacade { get; set; }

        public BaseViewModel(IPageDialogService dialogService, IAuthenticationFacade authenticationFacade, INavigationService navigationService = null) 
            : base (dialogService, navigationService)
        {
            AuthenticationFacade = authenticationFacade;
            DialogService = dialogService;
        }
    }
}
