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
using Xamarin.Forms.Platform.Android;
using FFImageLoading.Forms.Droid;
using FFImageLoading;

namespace CustomerPortalApp.Droid
{
	[Activity(ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity // was FormsApplicationActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			ToolbarResource = Resource.Layout.Toolbar;
			TabLayoutResource = Resource.Layout.Tabbar;



			base.OnCreate(bundle);

			CachedImageRenderer.Init();

			var config = new FFImageLoading.Config.Configuration()
			{
				VerboseLogging = false,
				VerbosePerformanceLogging = false,
				VerboseMemoryCacheLogging = false,
				VerboseLoadingCancelledLogging = false,
				Logger = new CustomLogger()
			};
			ImageService.Instance
			            .Initialize(config);


			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App(new AndroidInitializer()));
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
