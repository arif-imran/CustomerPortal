// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="iOSInitializer.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   iOSInitializer
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using CustomerPortal.DataAccess;

using Foundation;
using Grosvenor.Mobile.DataAccess.Services;
using Microsoft.Practices.Unity;
using Prism;
using Prism.Unity;
using UIKit;

namespace CustomerPortalApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.

    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IDatabaseConnectionService, DatabaseConnectionService>(new ContainerControlledLifetimeManager()); 
        }
    }
}
