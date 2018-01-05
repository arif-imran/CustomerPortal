using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CustomerPortal.UITest.iOS
{
	public class AppInitializer
	{
		private static IApp app;
		public static IApp App
		{
			get
			{
				if (app == null)
					throw new NullReferenceException("'AppInitializer.App' not set. Call 'AppInitializer.StartApp(platform)' before trying to access it.");
				return app;
			}
		}
		public static IApp StartApp(Platform platform)
		{
			// TODO: If the iOS or Android app being tested is included in the solution 
			// then open the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			//
			// The iOS project should have the Xamarin.TestCloud.Agent NuGet package
			// installed. To start the Test Cloud Agent the following code should be
			// added to the FinishedLaunching method of the AppDelegate:
			//
			//    #if ENABLE_TEST_CLOUD
			//    Xamarin.Calabash.Start();
			//    #endif
			if (platform == Platform.Android)
			{
				app = ConfigureApp
					.Android
					// TODO: Update this path to point to your Android app and uncomment the
					// code if the app is not included in the solution.
					//.ApkFile ("../../../Droid/bin/Debug/xamarinforms.apk")
                    .StartApp(Xamarin.UITest.Configuration.AppDataMode.DoNotClear);
			}
			else
			{
				app = ConfigureApp
					.iOS
					// TODO: Update this path to point to your iOS app and uncomment the
					// code if the app is not included in the solution.
					.Debug()
					.EnableLocalScreenshots()
					.PreferIdeSettings()
                    .StartApp();
			}
			return App;
		}
	}
}
