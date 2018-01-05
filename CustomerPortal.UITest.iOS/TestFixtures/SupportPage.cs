using NUnit.Framework;
using System;
using Xamarin.UITest;
using System.Linq;

namespace CustomerPortal.UITest.iOS
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class SupportPage
	{

		IApp app;
		Platform platform;

		public SupportPage(Platform Platform)
		{

			this.platform = Platform;

		}


		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}


		[Test]
		public void AccountPage_OpenAccountTab_Pass()
		{

			new LoginPage().LoginIfLoggedOut();

			new TabNavigation().Click("Support");

			app.WaitForElement(x => x.Text("Support"), timeout: TimeSpan.FromSeconds(5));
			app.Screenshot(BasePage.WaitedFor("SupportTab"));



		}
	}
}
