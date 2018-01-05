// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountStatementEntry.cs" company="">
//   
// </copyright>
// <summary>
//   The account statement entry.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System;

    /// <summary>
    /// The account statement entry.
    /// </summary>
    public class AccountStatementEntry
    {
        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        public double? Balance { get; set; }

        /// <summary>
        /// Gets or sets the charges.
        /// </summary>
        public double? Charges { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the invoice no.
        /// </summary>
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Gets or sets the invoice period.
        /// </summary>
        public string InvoicePeriod { get; set; }

        /// <summary>
        /// Gets or sets the payments.
        /// </summary>
        public double? Payments { get; set; }
    }
}