// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeaseDetails.cs" company="">
//   
// </copyright>
// <summary>
//   The lease details.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The lease details.
    /// </summary>
    public class LeaseDetails
    {
        /// <summary>
        /// Gets or sets the account balance.
        /// </summary>
        public double? AccountBalance { get; set; }

        /// <summary>
        /// Gets or sets the building manager.
        /// </summary>
        public string BuildingManager { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is direct debit.
        /// </summary>
        public bool IsDirectDebit { get; set; }

        /// <summary>
        /// Gets or sets the key lease documents.
        /// </summary>
        public List<Document> KeyLeaseDocuments { get; set; }

        /// <summary>
        /// Gets or sets the lease end date.
        /// </summary>
        public DateTime? LeaseEndDate { get; set; }

        /// <summary>
        /// Gets or sets the lease period.
        /// </summary>
        public string LeasePeriod { get; set; }

        /// <summary>
        /// Gets or sets the lease rent.
        /// </summary>
        public double LeaseRent { get; set; }

        /// <summary>
        /// Gets or sets the lease start date.
        /// </summary>
        public DateTime LeaseStartDate { get; set; }

        /// <summary>
        /// Gets or sets the lease status.
        /// </summary>
        public string LeaseStatus { get; set; }

        /// <summary>
        /// Gets or sets the property address.
        /// </summary>
        public string PropertyAddress { get; set; }

        /// <summary>
        /// Gets or sets the property code.
        /// </summary>
        public string PropertyCode { get; set; }

        /// <summary>
        /// Gets or sets the tenant id.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the tenant name.
        /// </summary>
        public string TenantName { get; set; }

        /// <summary>
        /// Gets or sets the tenure.
        /// </summary>
        public string Tenure { get; set; }

        /// <summary>
        /// Gets or sets the unit address.
        /// </summary>
        public string UnitAddress { get; set; }

        /// <summary>
        /// Gets or sets the unit address 1.
        /// </summary>
        public string UnitAddress1 { get; set; }

        /// <summary>
        /// Gets or sets the unit address 2.
        /// </summary>
        public string UnitAddress2 { get; set; }

        /// <summary>
        /// Gets or sets the unit id.
        /// </summary>
        public string UnitId { get; set; }
    }
}