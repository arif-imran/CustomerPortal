using System;
using Android.App;
using CustomerPortalApp.Droid.Services;
using CustomerPortalApp.Interfaces;
using Xamarin.Forms;


[assembly: Dependency(typeof(AndroidMethods))]
namespace CustomerPortalApp.Droid.Services
{


	public class AndroidMethods : IAndroidMethods
	{
		public AndroidMethods()
		{
		}

        public bool MoveAppToBack()
		{
			//Android.OS.Process.KillProcess(Android.OS.Process.MyPid());

         //   Android.OS.Process.

            var  ActivityInstance = Forms.Context as Activity;


            return  ActivityInstance.MoveTaskToBack(true);
		}
	}
}
