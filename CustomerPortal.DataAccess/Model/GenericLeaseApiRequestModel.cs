// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericLeaseApiRequestModel.cs" company="">
//   
// </copyright>
// <summary>
//   The generic lease api request model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System;

    /// <summary>
    /// The generic lease api request model.
    /// </summary>
    public class GenericLeaseApiRequestModel
    {
        /// <summary>
        /// Gets or sets the lease id.
        /// </summary>
        public Guid LeaseId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public string UserId { get; set; }
    }
}