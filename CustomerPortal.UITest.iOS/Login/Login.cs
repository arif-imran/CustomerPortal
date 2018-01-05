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
	public class Login
	{
		IApp app;
		Platform platform;

		public Login(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Login_ValidCredentials_Pass()
		{
			//app.Repl();
			new LogoutFromApp().LogoutIfLoggedIn();

            new LoginPage().Login(DefaultCredentials.email, DefaultCredentials.password);
			//Assert
			//app.WaitForElement(c => c.Class("UINavigationBar").Marked("Home"));
			//var elem = app.Query(c => c.Class("UINavigationBar").Marked("Home"));

		var elem = app.WaitForElement(x => x.Marked("Home"), timeout: TimeSpan.FromSeconds(10));
			app.Screenshot("Reached Dashboard");

			app.Screenshot("Login successful");
			Assert.IsTrue(elem != null);
		}
		[Test]
		public void Login_EmptyCredentials_Pass()
		{
			new LogoutFromApp().LogoutIfLoggedIn();

			new LoginPage().Login("", "");
			//Assert
          var elem = app.WaitForElement(x => x.Marked("BtnLogin"), timeout: TimeSpan.FromSeconds(5));

			app.Screenshot("Login disabled on empty credentails");
			Assert.IsTrue(elem != null);
		}


		[Test]
		public void Login_InvalidCredentials_Pass()
		{
			new LogoutFromApp().LogoutIfLoggedIn();

			new LoginPage().Login("Heyman123", "sajdhj!");

			var elem = app.WaitForElement(x => x.Marked("Home"), timeout: TimeSpan.FromSeconds(10));
			app.Screenshot("Reached Dashboard");

		}


	}
}
