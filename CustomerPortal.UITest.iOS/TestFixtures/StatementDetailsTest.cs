using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace CustomerPortal.UITest.iOS
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
    public class StatementDetailsTest
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
        /// Initializes a new instance of the <see cref="T:CustomerPortal.UITest.iOS.StatementDetailsTest"/> class.
        /// </summary>
        /// <param name="platform">Platform.</param>
        public StatementDetailsTest(Platform platform)
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
        /// Statements the details statement tab view pass.
        /// </summary>
   //     [Test]
   //     public void StatementDetails_StatementTabView_Pass()
   //     {
			////Arrange
			//new LoginPage().LoginIfLoggedOut();
			//new TabNavigation().Click("Account");

			////Act
			//app.Tap(x => x.Marked("Statement"));

			////Assert
			//app.WaitForElement(x => x.Marked("aiAccountStatementPage"), timeout: TimeSpan.FromSeconds(2));
   //         app.Screenshot("Account Tab Screen loaded with Statement Tab selected");
			
   //         //Act
			//app.Tap(x => x.Marked("Statement"));
			
   //         //Assert
			//app.WaitForElement(x => x.Marked("aiFullStatement"), timeout: TimeSpan.FromSeconds(4));
        //    app.Screenshot("Statement Data loaded");
        //}

        /// <summary>
        /// Statements the details current balance tab view pass.
        /// </summary>
        [Test]
		public void StatementDetails_CurrentBalanceTabView_Pass()
		{
			//Arrange
			new LoginPage().LoginIfLoggedOut();
			new TabNavigation().Click("Account");

			//Act
			app.Tap(x => x.Marked("Statement"));

            //Assert
			app.WaitForElement(x => x.Marked("aiAccountStatementPage"), timeout: TimeSpan.FromSeconds(2));
			app.Screenshot("Account Tab Screen loaded with Statement Tab selected");
			
            //Act
            app.Tap(x => x.Marked("Details of Current Balance"));

            //Assert
            app.WaitForElement(x => x.Marked("DUE DATE"), timeout: TimeSpan.FromSeconds(1));
            app.Screenshot("Current Balance Tab Loaded");
		}

        /// <summary>
        /// Statements the details statement tab empty data view pass.
        /// </summary>
		//[Test]
		//public void StatementDetails_StatementTab_EmptyDataView_Pass()
		//{
		//	//Arrange
		//	new LoginPage().LoginIfLoggedOut();
		//	new TabNavigation().Click("Account");

		//	//Act
		//	app.Tap(x => x.Marked("Statement"));

		//	//Assert
		//	app.WaitForElement(x => x.Marked("aiAccountStatementPage"), timeout: TimeSpan.FromSeconds(2));
		//	app.Screenshot("Account Tab Screen loaded with Statement Tab selected");

		//	//Assert
		//	app.WaitForElement(x => x.Text("No records in the statement"), timeout: TimeSpan.FromSeconds(1));
  //          app.Screenshot("Empty Statement Message Loaded");
		//}

        /// <summary>
        /// Statements the details current balance tab empty data view pass.
        /// </summary>
        /// 
		//[Test]
		//public void StatementDetails_CurrentBalanceTab_EmptyDataView_Pass()
		//{
		//	//Arrange
		//	new LoginPage().LoginIfLoggedOut();
		//	new TabNavigation().Click("Account");

		//	//Act
		//	app.Tap(x => x.Marked("Statement"));

		//	//Assert
		//	app.WaitForElement(x => x.Marked("aiAccountStatementPage"), timeout: TimeSpan.FromSeconds(2));
		//	app.Screenshot("Account Tab Screen loaded with Statement Tab selected");

		//	//Act
		//	app.Tap(x => x.Marked("Details of Current Balance"));

		//	//Assert
		//	app.WaitForElement(x => x.Text("You have no outstanding charges"), timeout: TimeSpan.FromSeconds(1));
  //          app.Screenshot("Empty Current Balance Message Loaded");
		//}

    }
}
