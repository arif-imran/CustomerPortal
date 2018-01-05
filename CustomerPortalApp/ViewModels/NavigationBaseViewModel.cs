// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NavigationBaseViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   Navigation base view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortalApp.ViewModels
{
    using System.Windows.Input;
    using CustomerPortal.Facade.Facades;
    using Grosvenor.Mobile.Common.Utils;
    using Grosvenor.Mobile.Forms.ViewModels;
    using Prism.Commands;
    using Prism.Navigation;
    using Prism.Services;

    /// <summary>
    ///     Navigation base view model.
    /// </summary>
    public class NavigationBaseViewModel : BaseViewModel, INavigationAware
    {
        /// <summary>Initializes a new instance of the <see cref="T:CustomerPortalApp.ViewModels.NavigationBaseViewModel"/> class.</summary>
        /// <param name="dialogService">Dialog service.</param>
        /// <param name="authenticationFacade">Authentication facade.</param>
        public NavigationBaseViewModel(IPageDialogService dialogService, IAuthenticationFacade authenticationFacade, INavigationService navigationService = null)
            : base(dialogService, authenticationFacade, navigationService)
        {
            if (this.NavigationService != null)
            {
                this.GoBackCommand = new DelegateCommand(() =>
                {
                    this.NavigationService.GoBackAsync().Forget();
                });
            }
        }


        /// <summary>
        /// Gets or sets the go back commnad.
        /// </summary>
        /// <value>The go back commnad.</value>
        public ICommand GoBackCommand { get; set; }

        /// <summary>Ons the navigated from.</summary>
        /// <param name="parameters">Parameters.</param>
        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        /// <summary>Ons the navigated to.</summary>
        /// <param name="parameters">Parameters.</param>
        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        /// <summary>Ons the navigating to.</summary>
        /// <param name="parameters">Parameters.</param>
        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}