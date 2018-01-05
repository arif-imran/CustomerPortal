﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CustomerPortal.UITest.iOS
{

	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Logout
	{
		IApp app;
		Platform platform;

		public Logout(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Dashboard_Logout_Pass()
		{

			new LoginPage().LoginIfLoggedOut();

			new LogoutFromApp().Logout();
		}

	}
}
