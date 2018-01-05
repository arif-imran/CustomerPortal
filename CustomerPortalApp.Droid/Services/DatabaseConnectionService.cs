using System;
using CustomerPortal.DataAccess;
using Grosvenor.Mobile.DataAccess.Services;
using SQLite;

namespace CustomerPortalApp.Droid
{
	public class DatabaseConnectionService : IDatabaseConnectionService
	{
		public SQLiteConnection DbConnection()
		{
			var dbName = "CustomerPortal.db3";
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			return new SQLiteConnection(System.IO.Path.Combine(path, dbName));
		}
	}
}
