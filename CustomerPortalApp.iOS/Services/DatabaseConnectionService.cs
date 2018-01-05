// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DatabaseConnectionService.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   DatabaseConnectionService
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using CustomerPortal.DataAccess;
using Grosvenor.Mobile.DataAccess.Services;
using SQLite;

namespace CustomerPortalApp.iOS
{
    public class DatabaseConnectionService : IDatabaseConnectionService
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "CustomerPortal.db3";
            string personalFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder, "..", "Library");
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }
    }
}