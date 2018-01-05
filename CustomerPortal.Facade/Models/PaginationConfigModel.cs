// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaginationConfigModel.cs" company="">
//   
// </copyright>
// <summary>
//   The pagination config model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    /// <summary>The pagination config model.</summary>
    public class PaginationConfigModel
    {
        /// <summary>Gets or sets the number items.</summary>
        public int NumberItems { get; set; }

        /// <summary>Gets or sets the order by.</summary>
        public string OrderBy { get; set; }

        /// <summary>Gets or sets the page to get.</summary>
        public int PageToGet { get; set; }
    }
}