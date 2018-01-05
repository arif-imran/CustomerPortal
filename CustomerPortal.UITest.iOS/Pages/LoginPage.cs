using System;
using System.Linq;
using Xamarin.UITest;
namespace CustomerPortal.UITest.iOS
{
	public class LoginPage : BasePage
	{


		public LoginPage()
		{
		}

		public void LoginIfLoggedOut()
		{

			app.WaitForElement(x => x.Marked("LoginTest"));


			if (app.Query("BtnLogin").Any())
			{
				Login(DefaultCredentials.email, DefaultCredentials.password);
			}

		}
		public void Login(string email, string password)
		{
			//Arrange
            app.WaitForElement((arg) => arg.Marked("txtEmail"), timeout: TimeSpan.FromSeconds(20));
			app.Screenshot(WaitedFor("LoginPage"));

			app.EnterText("txtEmail", email);
			app.Screenshot("EmailID entered");

			app.EnterText("txtPassword", password);
			app.Screenshot("Password entered");

			app.DismissKeyboard();
			app.Screenshot("Keyboard closed");
			//Act
			app.Tap("BtnLogin");
			app.Screenshot("Login button clicked");


		}
	}

	static class DefaultCredentials
	{
		public const string email = "laura.weatherhead@screenmedia.co.uk";
		public const string password = "Mellon123!";

	}
}
