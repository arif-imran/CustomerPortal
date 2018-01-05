// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AppDelegate.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   AppDelegate
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using CustomerPortal.DataAccess;
using FFImageLoading;
using FFImageLoading.Forms.Touch;
using Foundation;
using Microsoft.Practices.Unity;
using Prism;
using Prism.Unity;
using UIKit;

namespace CustomerPortalApp.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif


			CachedImageRenderer.Init();

			var config = new FFImageLoading.Config.Configuration()
			{
				VerboseLogging = false,
				VerbosePerformanceLogging = false,
				VerboseMemoryCacheLogging = false,
				VerboseLoadingCancelledLogging = false,
				Logger = new CustomLogger(),
			};
			ImageService.Instance.Initialize(config);

			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App(new iOSInitializer()));

			return base.FinishedLaunching(app, options);
		}


		public class CustomLogger : FFImageLoading.Helpers.IMiniLogger
		{
			public void Debug(string message)
			{
				Console.WriteLine(message);
			}

			public void Error(string errorMessage)
			{
				Console.WriteLine(errorMessage);
			}

			public void Error(string errorMessage, Exception ex)
			{
				Error(errorMessage + System.Environment.NewLine + ex.ToString());
			}
		}
	}
}
