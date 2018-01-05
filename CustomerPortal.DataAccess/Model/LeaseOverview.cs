// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeaseOverview.cs" company="">
//   
// </copyright>
// <summary>
//   The lease overview.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System;

    /// <summary>The lease overview.</summary>
    public class LeaseOverview
    {
        /// <summary>Gets or sets the account balance.</summary>
        public double? AccountBalance { get; set; }

        /// <summary>Gets or sets the full lease address.</summary>
        public string FullLeaseAddress { get; set; }

        /// <summary>Gets or sets a value indicating whether has maintenance.</summary>
        public bool HasMaintenance { get; set; }

        /// <summary>Gets or sets the lease account number.</summary>
        public string LeaseAccountNumber { get; set; }

        /// <summary>Gets or sets the lease address.</summary>
        public string LeaseAddress { get; set; }

        /// <summary>Gets or sets the lease id.</summary>
        public Guid LeaseId { get; set; }

        /// <summary>Gets or sets the lease property id.</summary>
        public Guid LeasePropertyId { get; set; }

        /// <summary>Gets or sets the lease unit.</summary>
        public string LeaseUnit { get; set; }

        /// <summary>Gets or sets the number of jobs.</summary>
        public int NumberOfJobs { get; set; }
    }
}