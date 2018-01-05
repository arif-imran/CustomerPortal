using System;
using System.Globalization;
using CustomerPortal.Common;
using Prism.Mvvm;

namespace CustomerPortalApp.ViewModels
{
    public class StatementsViewModel : BindableBase
    {
        /// <summary>The date.</summary>
        private string dueDate;

        /// <summary>The invoice no.</summary>
        private string invoiceNo;

        /// <summary>The invoice period.</summary>
        private string invoicePeriod;

        /// <summary>The description.</summary>
        private string description;

        /// <summary>The charges.</summary>
        private double charges;

        /// <summary>The payments.</summary>
        private double invoiceAmount;

        /// <summary>
        /// The balance.
        /// </summary>
        private double balance;

        /// <summary>
        /// The index.
        /// </summary>
        private int index;

        /// <summary>
        /// The net due.
        /// </summary>
        private double netDue;

        /// <summary>
        /// The paid amount.
        /// </summary>
        private double paidAmount;

        /// <summary>
        /// The status.
        /// </summary>
        private string status;

        /// <summary>
        /// The payments.
        /// </summary>
        private double payments;

        /// <summary>
        /// The amount.
        /// </summary>
        private double amount;

        /// <summary>
        /// Gets the year.
        /// </summary>
        /// <value>The year.</value>
        public string Year
        {
            get
            {
                return DateTime.ParseExact(this.DueDate, SharedConfig.ShortDateFormat, CultureInfo.InvariantCulture).Year.ToString();
            }
        }

        /// <summary>
        /// Gets the month.
        /// </summary>
        /// <value>The month.</value>
		public string Month
        {
            get
            {
                return DateTime.ParseExact(this.DueDate, SharedConfig.ShortDateFormat, CultureInfo.InvariantCulture).ToString("MMM");
            }
        }

        /// <summary>
        /// Gets the day.
        /// </summary>
        /// <value>The day.</value>
		public string Day
        {
            get
            {
                return DateTime.ParseExact(this.DueDate, SharedConfig.ShortDateFormat, CultureInfo.InvariantCulture).Day.ToString();
            }
        }

        /// <summary>Gets or sets the date.</summary>
        public string DueDate
        {
            get
            {
                return this.dueDate;
            }

            set
            {
                this.SetProperty(ref this.dueDate, value);
            }
        }

        public double NetDue
        {
            get
            {
                return this.netDue;
            }

            set
            {
                this.SetProperty(ref this.netDue, value);
            }
        }

        /// <summary>Gets or sets the invoice no.</summary>
        public string InvoiceNo
        {
            get
            {
                return this.invoiceNo;
            }

            set
            {
                this.SetProperty(ref this.invoiceNo, value);
            }
        }

        /// <summary>Gets or sets the invoice period.</summary>
        public string InvoicePeriod
        {
            get
            {
                return this.invoicePeriod;
            }

            set
            {
                this.SetProperty(ref this.invoicePeriod, value);
            }
        }

        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.SetProperty(ref this.description, value);
            }
        }

        /// <summary>Gets or sets the charges.</summary>
        public double Charges
        {
            get
            {
                return this.charges;
            }

            set
            {
                this.SetProperty(ref this.charges, value);
            }
        }

        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.SetProperty(ref this.status, value);
            }
        }

        /// <summary>
        /// Gets or sets the invoice amount.
        /// </summary>
        /// <value>The invoice amount.</value>
        public double InvoiceAmount
        {
            get
            {
                return this.invoiceAmount;
            }

            set
            {
                this.SetProperty(ref this.invoiceAmount, value);
            }
        }

        /// <summary>
        /// Gets or sets the paid amount.
        /// </summary>
        /// <value>The paid amount.</value>
        public double PaidAmount
        {
            get
            {
                return this.paidAmount;
            }

            set
            {
                this.SetProperty(ref this.paidAmount, value);
            }
        }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        public double Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.SetProperty(ref this.balance, value);
            }
        }

        /// <summary>
        /// Gets or sets the payments.
        /// </summary>
        /// <value>The payments.</value>
        public double Payments
        {
            get
            {
                return this.payments;
            }

            set
            {
                this.SetProperty(ref this.payments, value);
            }
        }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
		public double Amount
        {
            get
            {
                return this.amount = this.payments != 0 ? this.payments : this.charges;
            }
        }

        /// <summary>
        /// Gets the display amount.
        /// </summary>
        /// <value>The display amount.</value>
        public double DisplayAmount 
        {
            get 
            {
                return this.Type == StatementType.Balance ? this.InvoiceAmount : this.Amount;
            }
        }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>The index.</value>
        public int Index
        {
            get
            {
                return this.index;
            }
            set
            {
                SetProperty(ref this.index, value);
            }
        }

        /// <summary>
        /// Gets the due date date.
        /// </summary>
        /// <value>The due date date.</value>
        public DateTime DueDateDate
        {
            get
            {
                if (string.IsNullOrEmpty(this.dueDate))
                {
                    return DateTime.Now;
                }
                else
                {
                    return DateTime.ParseExact(this.dueDate, SharedConfig.ShortDateFormat, CultureInfo.InvariantCulture);
                }
            }
        }

        /// <summary>
        /// Statement type.
        /// </summary>
        public enum StatementType
        {
            Balance,
            Statement
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public StatementType Type { get; set; }
    }
}