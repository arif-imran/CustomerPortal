using System;
using Android.Content.Res;
using CustomerPortalApp.Droid;
using CustomerPortalApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(CommonUtility))]
namespace CustomerPortalApp.Droid
{
	public class CommonUtility : ICommonUtility
	{
		public int ScreenHeight()
		{
            return  (int)(Forms.Context.Resources.DisplayMetrics.HeightPixels / Forms.Context.Resources.DisplayMetrics.Density);
		}

		public int ScreenWidth()
		{
			return (int)(Forms.Context.Resources.DisplayMetrics.WidthPixels / Forms.Context.Resources.DisplayMetrics.Density);
		}
	}
}
