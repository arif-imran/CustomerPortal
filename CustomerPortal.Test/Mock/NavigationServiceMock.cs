// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="NavigationServiceMock.cs" company="Grosvenor">
// //   
// // </copyright>
// // <summary>
// //   NavigationServiceMock
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Common;
using Prism.Services;
using System.Threading.Tasks;
using Prism.Navigation;
using System;
using Xamarin.Forms;
using Prism.Logging;
using Grosvenor.Mobile.DataAccess.Services;
using Grosvenor.Mobile.DataAccess.Model;

namespace CustomerPortal.Test
{

    public class NavigationServiceMock : PageNavigationService
    {        
        public NavigationServiceMock(IApplicationProvider applicationProvider, ILoggerFacade logger) : base (applicationProvider, null)
        {
        }

        public string LastNavigationUrl { get; private set; }

        protected override Page CreatePage(string segmentName)
        {
            return new Page();
        }

        public override Task NavigateAsync(Uri uri, NavigationParameters parameters = null, bool? useModalNavigation = default(bool?), bool animated = true)
        {
            return base.NavigateAsync(uri, parameters, useModalNavigation, animated);

        }

        public override Task NavigateAsync(string name, NavigationParameters parameters = null, bool? useModalNavigation = default(bool?), bool animated = true)
        {
            this.LastNavigationUrl = name;

            return base.NavigateAsync(name, parameters, useModalNavigation, animated);
        }
    }
}