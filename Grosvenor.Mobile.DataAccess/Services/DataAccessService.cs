// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataAccessService.cs" company="">
//   
// </copyright>
// <summary>
//   Data access service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Grosvenor.Mobile.DataAccess.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using Grosvenor.Mobile.DataAccess.Model;

    using SQLite;

    /// <summary>
    ///     Data access service.
    /// </summary>
    public abstract class BaseDataAccessService : IDataAccessService
    {
        /// <summary>The Database connection.</summary>
        private readonly IDatabaseConnectionService databaseConnection;

        /// <summary>The Database lock.</summary>
        private readonly object databaseLock = new object();

        /// <summary>Initializes a new instance of the <see cref="BaseDataAccessService"/> class. Initializes a new instance of the<see cref="T:Grosvenor.Mobile.DataAccess.Services.DataAccessService"/>
        ///     class.</summary>
        /// <param name="databaseConnection">Database connection.</param>
        protected BaseDataAccessService(IDatabaseConnectionService databaseConnection)
        {
            this.databaseConnection = databaseConnection;
        }

        /// <summary>Gets or sets the database.</summary>
        protected SQLiteConnection Database { get; set; }

        /// <summary>
        ///     Deletes all.
        /// </summary>
        /// <returns>The all.</returns>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public int DeleteAll<T>()
            where T : new()
        {
            lock (this.databaseLock)
            {
                var result = this.Database.DeleteAll<T>();
                return result;
            }
        }

        /// <summary>Gets all.</summary>
        /// <returns>The all.</returns>
        /// <param name="tableName">Table name.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public List<T> GetAll<T>(string tableName = "")
            where T : new()
        {
            lock (this.databaseLock)
            {
                if (string.IsNullOrEmpty(tableName)) tableName = typeof(T).Name;

                var result = this.Database.Query<T>($"SELECT * FROM {tableName}").ToList();

                return result;
            }
        }

        /// <summary>Gets the by identifier.</summary>
        /// <returns>The by identifier.</returns>
        /// <param name="id">Identifier.</param>
        /// <param name="tableName">Table name.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public T GetById<T>(int id, string tableName = "")
            where T : BaseEntity, new()
        {
            lock (this.databaseLock)
            {
                if (string.IsNullOrEmpty(tableName)) tableName = typeof(T).Name;

                var result = this.Database.Query<T>($"SELECT * FROM {tableName} WHERE Id = {id}").FirstOrDefault();

                return result;
            }
        }

        /// <summary>
        ///     Initialize this instance.
        /// </summary>
        public virtual void Initialize()
        {
            this.Database = this.databaseConnection.DbConnection();
        }

        /// <summary>Save the specified item.</summary>
        /// <returns>The save.</returns>
        /// <param name="item">Item.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public int Save<T>(T item)
            where T : BaseEntity
        {
            lock (this.databaseLock)
            {
                if (item.Id != 0)
                {
                    this.Database.Update(item);
                    return item.Id;
                }
                else
                {
                    this.Database.Insert(item);
                    return item.Id;
                }
            }
        }
    }
}