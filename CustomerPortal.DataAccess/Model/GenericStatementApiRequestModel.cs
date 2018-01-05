// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericStatementApiRequestModel.cs" company="">
//   
// </copyright>
// <summary>
//   The generic statement api request model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System;

    /// <summary>
    /// The generic statement api request model.
    /// </summary>
    public class GenericStatementApiRequestModel
    {
        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets the lease id.
        /// </summary>
        public Guid LeaseId { get; set; }

        /// <summary>
        /// Gets or sets the number of items.
        /// </summary>
        public int NumberOfItems { get; set; }

        /// <summary>
        /// Gets or sets the page to get.
        /// </summary>
        public int PageToGet { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public string StartDate { get; set; }
    }
}