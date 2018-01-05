// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LoginPageViewModel.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   LoginPageViewModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using CustomerPortal.Facade;
using Grosvenor.Mobile.Common;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using System.Net;
using Xamarin.Forms;
using Prism.Services;
using CustomerPortal.Common;
using CustomerPortal.Facade.Facades;
using CustomerPortal.Facade.Models;
using Grosvenor.Mobile.DataAccess.Services;
using Grosvenor.Mobile.DataAccess.Model;
using Grosvenor.Mobile.Common.Utils;

namespace CustomerPortalApp.ViewModels
{
	/// <summary>
	/// Login page view model.
	/// </summary>
	public class LoginPageViewModel : NavigationBaseViewModel
	{
		readonly INavigationService navigationService;
		readonly IAuthenticationFacade authenticationFacade;
		readonly IKeychainService keychainService;

		public LoginPageViewModel(INavigationService navigationService,
		                          IAuthenticationFacade authenticationFacade,
		                          IPageDialogService dialogService,
		                          IKeychainService keychainService)
		: base(dialogService, authenticationFacade, navigationService)
		{
			this.authenticationFacade = authenticationFacade;
			this.navigationService = navigationService;
			this.keychainService = keychainService;

			this.LoginCommand = new DelegateCommand(() => { this.ExecuteAsyncTask(this.LoginAction).Forget(); })
			    .ObservesCanExecute(() => this.CanLogin)
			    .ObservesProperty(() => this.Username)
			    .ObservesProperty(() => this.Password);
		}

        public bool CanLogin
        {
            get
            {
                return !string.IsNullOrEmpty(this.Username) && !string.IsNullOrEmpty(this.Password);
            }
        }

        /// <summary>
        /// The username.
        /// </summary>
        private string username;

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                SetProperty(ref this.username, value);
            }
        }

        /// <summary>
        /// The password.
        /// </summary>
        private string password;

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                SetProperty(ref this.password, value);
            }
        }

        /// <summary>
        /// Gets or sets the login command.
        /// </summary>
        /// <value>The login command.</value>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// Logins the action.
        /// </summary>
        private async Task LoginAction()
        {
            var loginRequest = new BaseFacadeRequestModelWithContent<LoginRequestModel>
            {
                Content = new LoginRequestModel
                {
                    ApplicationUsesRefreshTokens = true,
                    Email = this.Username,
                    Password = this.Password
                }
            };

			// ================ Just for Testing without Api call =====================

			//var identity = await this.authenticationFacade.LoginAsync(this.Username, this.Password);

			//// if success navigate to HomePage 
			//// if not display message
			//if (identity.IsValidUser)
			//{
			//	this.navigationService.NavigateAsync("MainMasterDetailPage/MainNavigationPage/HomePage").Forget();
			//}
			//else
			//{
			//	// Dialog service show login error. 
			//	await this.DialogService.DisplayAlertAsync(Constants.LoginErrorMessageTitle, Constants.LoginErrorMessage, Constants.LoginErrorMessageOkButton);
			//}

			// =============================== End  =============================================


			// authenticate 
			var loginResponse = await this.authenticationFacade.Login(loginRequest);

			// if success navigate to HomePage 
			// if not display message
			if (loginResponse.StatusCode == HttpStatusCode.OK)
			{
				//shahbaaz 05/07/2017: changed URI from relative to absolute for clearning nav stack
				this.navigationService.NavigateAsync("app:///MainMasterDetailPage/Navigation/HomePage/DashboardPage").Forget();

              // this.navigationService.NavigateAsync("MainMasterDetailPage/Navigation/HomePage/DashboardPage").Forget();
			}
			else
			{
				// Dialog service show login error. 
				await this.DialogService.DisplayAlertAsync(Constants.LoginErrorMessageTitle, Constants.LoginErrorMessage, Constants.LoginErrorMessageOkButton);
			}
		}


        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }


    /// <summary>
    /// Navigation base view model.
    /// </summary>
    public class BlankPageViewModel : NavigationBaseViewModel
    {
        readonly INavigationService navigationService;
        readonly IAuthenticationFacade authenticationFacade;
        readonly IKeychainService keychainService;

        public BlankPageViewModel(INavigationService navigationService,
                                  IAuthenticationFacade authenticationFacade,
                                  IPageDialogService dialogService,
                                  IKeychainService keychainService)
        : base(dialogService, authenticationFacade, navigationService)
        {
            this.authenticationFacade = authenticationFacade;
            this.navigationService = navigationService;
            this.keychainService = keychainService;
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            this.Title = parameters.GetValue<string>("Title");
        }
    }
}
