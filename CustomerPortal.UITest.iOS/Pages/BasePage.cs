using System;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.iOS;

namespace CustomerPortal.UITest.iOS

{
	public class BasePage
	{
		protected readonly IApp app;

		protected readonly bool OnAndroid;
		protected readonly bool OniOS;

		public BasePage()
		{
			app = AppInitializer.App;

			OnAndroid = app.GetType() == typeof(AndroidApp);
			OniOS = app.GetType() == typeof(iOSApp);
		}





		public static string TappedOn(string elemTapped)
	{

		elemTapped = "Tapped on " + elemTapped;

				return elemTapped;
		}


        public static string WaitedFor(string elemWaited)
		{

		elemWaited = "Waited for " + elemWaited;

			return elemWaited;
				}



	}
}
