// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataAccessService.cs" company="">
//   
// </copyright>
// <summary>
//   Data access service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Grosvenor.Mobile.DataAccess.Services
{
    using System.Collections.Generic;

    using Grosvenor.Mobile.DataAccess.Model;

    /// <summary>
    ///     Data access service.
    /// </summary>
    public interface IDataAccessService
    {
        /// <summary>
        ///     Deletes all.
        /// </summary>
        /// <returns>The all.</returns>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        int DeleteAll<T>()
            where T : new();

        /// <summary>Gets all.</summary>
        /// <returns>The all.</returns>
        /// <param name="tableName">Table name.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        List<T> GetAll<T>(string tableName = "")
            where T : new();

        /// <summary>Gets the by identifier.</summary>
        /// <returns>The by identifier.</returns>
        /// <param name="id">Identifier.</param>
        /// <param name="tableName">Table name.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        T GetById<T>(int id, string tableName = "")
            where T : BaseEntity, new();

        /// <summary>
        ///     Initialize this instance.
        /// </summary>
        void Initialize();

        /// <summary>Save the specified item.</summary>
        /// <returns>The save.</returns>
        /// <param name="item">Item.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        int Save<T>(T item)
            where T : BaseEntity;
    }
}