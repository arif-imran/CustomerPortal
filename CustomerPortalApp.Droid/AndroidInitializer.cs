// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AndroidInitializer.cs" company="Grosvenor">
// //   
// // </copyright>
// // <summary>
// //   AndroidInitializer
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Prism;
using Prism.Unity;
using Microsoft.Practices.Unity;
using CustomerPortal.DataAccess;
using Grosvenor.Mobile.DataAccess.Services;

namespace CustomerPortalApp.Droid
{

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {
            UnityContainerExtensions.RegisterType<IDatabaseConnectionService, DatabaseConnectionService>(container, new ContainerControlledLifetimeManager());
        }
    }
}
