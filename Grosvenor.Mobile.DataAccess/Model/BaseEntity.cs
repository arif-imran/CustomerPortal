// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseEntity.cs" company="">
//   
// </copyright>
// <summary>
//   The base entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Grosvenor.Mobile.DataAccess.Model
{
    using MvvmHelpers;

    using SQLite;

    /// <summary>The base entity.</summary>
    public class BaseEntity : ObservableObject
    {
        /// <summary>The id.</summary>
        private int id;

        /// <summary>Gets or sets the id.</summary>
        [PrimaryKey]
        [AutoIncrement]
        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
                this.SetProperty(ref this.id, value);
            }
        }
    }
}