using System;
using System.Linq;

namespace CustomerPortal.UITest.iOS
{
	public class LogoutFromApp : BasePage
	{
	public LogoutFromApp()
			{
			}

		public void LogoutIfLoggedIn()
		{

			app.WaitForElement(x => x.Marked("LoginTest"));

			if (app.Query("menu").Any())
			{
				Logout();

			}

		}

		public void Logout()
		{

			app.WaitForElement(x => x.Marked("Home"), timeout: TimeSpan.FromSeconds(10));
			app.Screenshot(WaitedFor("Homepage"));

            if (OniOS)
            {
                app.Tap(x => x.Marked("menu"));
            }

            else if (OnAndroid)
            {
				app.Tap(x => x.Class("android.support.v7.widget.AppCompatImageButton").Marked("OK"));
            }

			app.Screenshot(TappedOn("Hamburger icon"));

			app.Tap(x => x.Text("Logout"));
			app.Screenshot(TappedOn("Logout"));

			app.WaitForElement(x => x.Marked("OK"));
			app.Screenshot(WaitedFor("Popup"));

			app.Tap(x => x.Marked("OK"));
			app.Screenshot(TappedOn("OK button in popup"));

			app.WaitForElement(x => x.Marked("BtnLogin"), timeout: TimeSpan.FromSeconds(10));
			app.Screenshot(WaitedFor("FinalScreen: Login"));


		}





	}
}
