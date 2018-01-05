// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="GrosvenorBaseViewModel.cs" company="Grosvenor">
// //   
// // </copyright>
// // <summary>
// //   GrosvenorBaseViewModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using System.Threading.Tasks;
using Grosvenor.Mobile.Common;
using Prism.Mvvm;
using Prism.Services;
using Xamarin.Forms;

namespace Grosvenor.Mobile.Forms.ViewModels
{
    using Grosvenor.Mobile.Common.Utils;
    using Prism.Navigation;

    public class GrosvenorBaseViewModel : BindableBase
    {
        /// <summary>The is busy.</summary>
        private bool isBusy;

        /// <summary>The title.</summary>
        private string title;

        protected INavigationService NavigationService { get; set; }

        /// <summary>Initializes a new instance of the <see cref="GrosvenorBaseViewModel"/> class.</summary>
        /// <param name="dialogService">The dialog service.</param>
        public GrosvenorBaseViewModel(IPageDialogService dialogService, INavigationService navigationService = null)
        {
            NavigationService = navigationService;
            this.DialogService = dialogService;
        }

        /// <summary>Gets or sets a value indicating whether is busy.</summary>
        public bool IsBusy
        {
            get
            {
                return this.isBusy;
            }

            set
            {
                this.SetProperty(ref this.isBusy, value);
            }
        }

        /// <summary>Gets or sets the title.</summary>
        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.SetProperty(ref this.title, value);
            }
        }

        /// <summary>Gets or sets the dialog service.</summary>
        protected IPageDialogService DialogService { get; set; }

        /// <summary>Executes the action.</summary>
        /// <returns>The action.</returns>
        /// <param name="action">Action.</param>
        protected async Task ExecuteAction(Action action)
        {
            Device.BeginInvokeOnMainThread(() => { this.IsBusy = true; });

            try
            {
                action();
            }
            catch (Exception ex)
            {
                // Dialog service, show error. 
                await this.DialogService.DisplayAlertAsync(
                    GrosvenorConstants.ApiCallErrorMessageTitle,
                    $"{GrosvenorConstants.ApiCallErrorMessage} {Environment.NewLine} Error: {ex.Message}",
                    GrosvenorConstants.ApiCallErrorMessageOkButton);

                // todo
                // Analytics service log error. 
            }

            Device.BeginInvokeOnMainThread(() => { this.IsBusy = false; });
        }

        /// <summary>Executes the async task.</summary>
        /// <returns>The async task.</returns>
        /// <param name="actionDelegate">Action delegate.</param>
        protected async Task ExecuteAsyncTask(Func<Task> actionDelegate)
        {
            Device.BeginInvokeOnMainThread(() => { this.IsBusy = true; });

            try
            {
                await this.ExecuteAsyncTaskWithNoLoading(actionDelegate);
            }
            catch (Exception ex)
            {
                // Dialog service, show error. 
                await this.DialogService.DisplayAlertAsync(
                    GrosvenorConstants.ApiCallErrorMessageTitle,
                    GrosvenorConstants.ApiCallErrorMessage,
                    GrosvenorConstants.ApiCallErrorMessageOkButton);

                // todo
                // Analytics service log error. 
            }

            Device.BeginInvokeOnMainThread(() => { this.IsBusy = false; });
        }

        /// <summary>Executes the async task with no loading.</summary>
        /// <returns>The async task with no loading.</returns>
        /// <param name="actionDelegate">Action delegate.</param>
        protected async Task ExecuteAsyncTaskWithNoLoading(Func<Task> actionDelegate)
        {
            try
            {
                await actionDelegate();
            }
            catch (Exception ex)
            {
                // Dialog service, show error. 
                await this.DialogService.DisplayAlertAsync(
                    GrosvenorConstants.ApiCallErrorMessageTitle,
                    $"{GrosvenorConstants.ApiCallErrorMessage} {Environment.NewLine} Error: {ex.Message}",
                    GrosvenorConstants.ApiCallErrorMessageOkButton);

                // todo
                // Analytics service log error. 
            }
        }
    }
}
