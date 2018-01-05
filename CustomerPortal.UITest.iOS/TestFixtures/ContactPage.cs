using NUnit.Framework;
using System;
using Xamarin.UITest;
using System.Linq;

namespace CustomerPortal.UITest.iOS
{
[TestFixture(Platform.Android)]
[TestFixture(Platform.iOS)]
	public class ContactPage
	{

IApp app;
Platform platform;

		public ContactPage(Platform Platform)
		{

			this.platform = Platform;
		
		}

[SetUp]
public void BeforeEachTest()
{
	app = AppInitializer.StartApp(platform);
}



[Test]
public void Dashboard_ContactPageTab_Pass()
		{
			new LoginPage().LoginIfLoggedOut();

	new TabNavigation().Click("Contact");
	app.WaitForElement(x => x.Text("Contact"), timeout: TimeSpan.FromSeconds(5));
	app.Screenshot("Tapped on view with class: UITabBarButtonLabel with text: Contact with marked: Contact");
	//app.Tap(x => x.Marked("+44(0)207312001"));
	//app.Screenshot("Tapped on view with class: UILabel with text: +44(0)207312001 with marked: +44(0)207312001");
}


[Test]
public void Dashboard_ContactViaPhone_Pass()
{
		new LoginPage().LoginIfLoggedOut();

	new TabNavigation().Click("Contact");

		//	Dashboard_ContactPageTab_Pass();
	app.WaitForElement(x => x.Text("Contact"), timeout: TimeSpan.FromSeconds(5));

	Test_ContactViaPhoneOrEmail("+44(0)207312001");
}

[Test]
public void Dashboard_ContactViaEmail_Pass()
{
//	Dashboard_ContactPageTab_Pass();

	new LoginPage().LoginIfLoggedOut();

	new TabNavigation().Click("Contact");

	app.WaitForElement(x => x.Text("Contact"), timeout: TimeSpan.FromSeconds(5));
    Test_ContactViaPhoneOrEmail("info@grosvenor.com");
}



		void Test_ContactViaPhoneOrEmail(string PhoneOrEmail)
		{
			app.Tap(x => x.Marked(PhoneOrEmail));
			app.Screenshot("Tapped on view with class: UILabel with text: " + PhoneOrEmail + "with marked:" + PhoneOrEmail);
		}


	}
}
