// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataAccessService.cs" company="">
//   
// </copyright>
// <summary>
//   The data access service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Services
{
    using CustomerPortal.DataAccess.Model;

    using Grosvenor.Mobile.DataAccess.Services;

    /// <summary>The data access service.</summary>
    public class DataAccessService : BaseDataAccessService
    {
        /// <summary>Initializes a new instance of the <see cref="DataAccessService"/> class.</summary>
        /// <param name="databaseConnection">The database connection.</param>
        public DataAccessService(IDatabaseConnectionService databaseConnection)
            : base(databaseConnection)
        {
        }

        /// <summary>The initialize.</summary>
        public override void Initialize()
        {
            base.Initialize();

            this.Database.CreateTable<Settings>();
        }
    }
}