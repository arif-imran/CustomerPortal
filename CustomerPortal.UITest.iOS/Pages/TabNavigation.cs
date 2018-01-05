using System;
namespace CustomerPortal.UITest.iOS
{
	public class TabNavigation:BasePage
	{
		public TabNavigation()
		{
		}
		public void Click(string tabname)
		{
			app.WaitForElement(x => x.Text("Home"), timeout: TimeSpan.FromSeconds(5));
			app.Screenshot(WaitedFor("Homepage"));

			app.Tap(x => x.Marked(tabname));
			app.Screenshot(TappedOn("tab: " + tabname));

		}

		public void TapHamburger()
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
		
		
		}
	}
}
