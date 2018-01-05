// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DatabaseConnectionServiceFake.cs" company="Grosvenor">
// //   
// // </copyright>
// // <summary>
// //   DatabaseConnectionServiceFake
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Common;
using Prism.Services;
using System.Threading.Tasks;
using Prism.Navigation;
using System;
using Xamarin.Forms;
using Prism.Logging;
using Grosvenor.Mobile.DataAccess.Services;
using Grosvenor.Mobile.DataAccess.Model;
using SQLite;

namespace CustomerPortal.Test
{

    public class DatabaseConnectionServiceFake : IDatabaseConnectionService
    {
        public SQLiteConnection DbConnection()
        {
            return new SQLiteConnection("fakePath", true);
        }
    }
}