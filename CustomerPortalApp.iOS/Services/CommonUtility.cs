using System;
using UIKit;
using CustomerPortalApp.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using CustomerPortalApp.Interfaces;

[assembly: Dependency(typeof(CommonUtility))]
namespace CustomerPortalApp.iOS
{
	public class CommonUtility : ICommonUtility
	{

		public int ScreenHeight()
		{
			int height = (int)UIScreen.MainScreen.Bounds.Size.Height;
			return height;
		}

		public int ScreenWidth()
		{
			int height = (int)UIScreen.MainScreen.Bounds.Size.Width;
			return height;
		}
	}
}