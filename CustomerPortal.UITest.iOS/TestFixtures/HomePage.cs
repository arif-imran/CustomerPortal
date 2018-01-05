﻿using NUnit.Framework;
using System;
using Xamarin.UITest;

namespace CustomerPortal.UITest.iOS
{
	
[TestFixture(Platform.Android)]
[TestFixture(Platform.iOS)]
	public class HomePage
	{
IApp app;
Platform platform;

public HomePage(Platform platform)
{
	this.platform = platform;
}

[SetUp]
public void BeforeEachTest()
{
	app = AppInitializer.StartApp(platform);
}


[Test]
public void Dashboard_SwipeAround_Pass()
{

	new LoginPage().LoginIfLoggedOut();

	app.WaitForElement(x => x.Text("Home"), timeout: TimeSpan.FromSeconds(5));

    app.Screenshot("Homepage loaded");

	app.ScrollDown();
	app.Screenshot("Swiped down page");

	app.ScrollUp();

    app.Screenshot("Swiped back up");

	var bounds = app.Query()[0].Rect;
	app.DragCoordinates(0.9f * bounds.Width, 0.23f * bounds.Height, 0.36f * bounds.Width, 0.22f * bounds.Height);

	app.Screenshot("Swiped carousel once");

	//bounds = app.Query()[0].Rect;
	app.DragCoordinates(0.9f * bounds.Width, 0.23f * bounds.Height, 0.36f * bounds.Width, 0.22f * bounds.Height);

    app.Screenshot("Swiped carousel second time");

	app.WaitForElement(x => x.Text("Home"), timeout: TimeSpan.FromSeconds(5));
	//app.Screenshot("Waited for view with class: UILabel with text: Home with marked: Home");
//	app.Tap(x => x.Class("Xamarin_Forms_Platform_iOS_Platform_DefaultRenderer").Index(34));

	//app.WaitForElement(x => x.Marked("t0006052"), timeout: TimeSpan.FromSeconds(5));
	app.Screenshot("Test Passed: Swipes on Carousel");
}

	}
}
