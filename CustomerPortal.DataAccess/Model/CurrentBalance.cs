// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CurrentBalance.cs" company="">
//   
// </copyright>
// <summary>
//   The current balance.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    /// <summary>
    /// The current balance.
    /// </summary>
    public class CurrentBalance
    {
        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        public double? Balance { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        public string DueDate { get; set; }

        /// <summary>
        /// Gets or sets the invoice amount.
        /// </summary>
        public double? InvoiceAmount { get; set; }

        /// <summary>
        /// Gets or sets the invoice no.
        /// </summary>
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Gets or sets the invoice period.
        /// </summary>
        public string InvoicePeriod { get; set; }

        /// <summary>
        /// Gets or sets the net due.
        /// </summary>
        public double? NetDue { get; set; }

        /// <summary>
        /// Gets or sets the paid amount.
        /// </summary>
        public double? PaidAmount { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }
    }
}