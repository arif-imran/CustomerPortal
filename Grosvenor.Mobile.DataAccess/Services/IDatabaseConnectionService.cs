// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDatabaseConnectionService.cs" company="">
//   
// </copyright>
// <summary>
//   The DatabaseConnectionService interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Grosvenor.Mobile.DataAccess.Services
{
    using SQLite;

    /// <summary>The DatabaseConnectionService interface.</summary>
    public interface IDatabaseConnectionService
    {
        /// <summary>The db connection.</summary>
        /// <returns>The <see cref="SQLiteConnection" />.</returns>
        SQLiteConnection DbConnection();
    }
}