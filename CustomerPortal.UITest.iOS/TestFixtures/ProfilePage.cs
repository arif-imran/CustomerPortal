using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CustomerPortal.UITest.iOS
{

	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class ProfilePage
	{
		IApp app;
		Platform platform;

		public ProfilePage(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Dashboard_AccountDetailsOnSlider_Pass()
		{
			new LoginPage().LoginIfLoggedOut();
			//if (app.Query("menu").Any())
			//{

			new TabNavigation().TapHamburger();

         var elem =  app.WaitForElement(x => x.Marked("TestUsername"), timeout: TimeSpan.FromSeconds(5));


            Assert.AreEqual(DefaultCredentials.email, elem.FirstOrDefault().Text);
            app.Screenshot("Profile info loaded");
			//}
		}


		[Test]
		public void Dashboard_NavigateToProfilePage_Pass()
		{
			new LoginPage().LoginIfLoggedOut();
			//if (app.Query("menu").Any())
			//{

			new TabNavigation().TapHamburger();

			app.Tap(x => x.Text("My Profile"));
			app.WaitForElement(x => x.Text("My Profile"), timeout: TimeSpan.FromSeconds(5));
			app.Screenshot(BasePage.WaitedFor("Profile Page"));
			//}
		}

	}
}
