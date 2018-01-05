// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LifecycleService.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   LifecycleService
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CustomerPortal.DataAccess;
using CustomerPortal.Facade;
using CustomerPortal.Facade.Facades;
using Grosvenor.Mobile.Common;
using Prism.Navigation;

namespace CustomerPortalApp
{
    using Grosvenor.Mobile.Common.Utils;
    using Grosvenor.Mobile.DataAccess.Services;

	public class LifecycleService : ILifecycleService
	{
		private INavigationService navigationService;
		private readonly ISettingsFacade settignsFacade;
		readonly IDataAccessService dataAccessService;
		readonly IKeychainService keychainService;

		public LifecycleService(ISettingsFacade settignsFacade, IDataAccessService dataAccessService, IKeychainService keychainService)
		{
			this.dataAccessService = dataAccessService;
			this.keychainService = keychainService;
		}

        /// <summary>
        /// Starts the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="navigationService">Navigation service.</param>
        public async Task StartAsync(INavigationService navigationService)
        {
            this.dataAccessService.Initialize();

			this.navigationService = navigationService;

			if (this.keychainService.AreCredentialsValid())
			{
				// navigate to HomePage
                //shahbaaz 05/07/2017: changed URI from relative to absolute for clearing nav stack
              this.navigationService.NavigateAsync("app:///MainMasterDetailPage/Navigation/HomePage/DashboardPage").Forget();
			}
			else
			{
				// navigate to Login Page
				this.navigationService.NavigateAsync("app:///LoginPage").Forget();
			}
		}

        /// <summary>
        /// Starts the on resume.
        /// </summaßry>
        /// <returns>The on resume.</returns>
        /// <param name="navigationService">Navigation service.</param>
        public async Task StartOnResume(INavigationService navigationService)
        {
            if (!this.keychainService.AreCredentialsValid())
            {
                navigationService.NavigateAsync("app:///LoginPage").Forget();
            }
        }
	}
}
