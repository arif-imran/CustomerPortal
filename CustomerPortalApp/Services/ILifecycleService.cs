// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ILifecycleService.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   ILifecycleService
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Prism.Navigation;

namespace CustomerPortalApp
{

    public interface ILifecycleService
    {
        /// <summary>
        /// Starts the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="navigationService">Navigation service.</param>
        Task StartAsync(INavigationService navigationService);

        /// <summary>
        /// Starts the on resume.
        /// </summary>
        /// <returns>The on resume.</returns>
        /// <param name="navigationService">Navigation service.</param>
        Task StartOnResume(INavigationService navigationService);
    }
}
