using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Linq;

namespace CustomerPortal.UITest.iOS
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
    public class PropertyDetailsTest
    {
        /// <summary>
        /// The app.
        /// </summary>
		IApp app;

        /// <summary>
        /// The platform.
        /// </summary>
		Platform platform;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CustomerPortal.UITest.iOS.PropertyDetailsTest"/> class.
        /// </summary>
        /// <param name="platform">Platform.</param>
        public PropertyDetailsTest(Platform platform)
        {
            this.platform = platform;
        }

        /// <summary>
        /// Befores the each test.
        /// </summary>
		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

        /// <summary>
        /// Properties the details check view pass.
        /// </summary>
		[Test]
		public void PropertyDetails_View_Pass()
		{
            //Arrange
            new LoginPage().LoginIfLoggedOut();
            new TabNavigation().Click("Account");

			//Act
			app.Tap(x => x.Marked("Property Details"));

			//Assert
			app.WaitForElement(x => x.Marked("aiLeaseDetails"), timeout: TimeSpan.FromSeconds(4));
			app.Screenshot("Property Details View loaded");
		}


        [Test]
        public void PropertyDetails_VerifyPropertyDetails_Pass()
		{
			//Arrange
			new LoginPage().LoginIfLoggedOut();
			new TabNavigation().Click("Account");

          //  app.Repl();

			var bounds = app.Query()[0].Rect;
			app.DragCoordinates(0.9f * bounds.Width, 0.23f * bounds.Height, 0.36f * bounds.Width, 0.22f * bounds.Height);

			app.Screenshot("Swiped carousel once");

			app.DragCoordinates(0.9f * bounds.Width, 0.23f * bounds.Height, 0.36f * bounds.Width, 0.22f * bounds.Height);

			app.Screenshot("Swiped carousel second time");


            //  app.Query(c => c.Id("MonthValue").Text
            var accno = app.WaitForElement(x => x.Marked("TestAccountNo"),timeout: TimeSpan.FromSeconds(4))?.FirstOrDefault().Text;


			app.Tap(x => x.Marked("Property Details"));

            app.Screenshot(BasePage.TappedOn("Property details list item"));

			app.WaitForElement(x => x.Marked("aiLeaseDetails"), timeout: TimeSpan.FromSeconds(4));


            var detailaccno = app.WaitForElement(x => x.Marked("TestDetailAccountNo"), timeout: TimeSpan.FromSeconds(4))?.FirstOrDefault().Text;

         var accnoSubstring = accno.Substring(accno.IndexOf(':') + 2);

            Assert.AreEqual(detailaccno, accnoSubstring);

			app.Screenshot("Account details matching with carousel selection");
		}





    }
}
