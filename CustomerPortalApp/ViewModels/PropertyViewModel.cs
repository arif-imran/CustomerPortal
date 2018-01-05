// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PropertyViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   The property view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortalApp.ViewModels
{
    using System;
    using Prism.Mvvm;

    /// <summary>
    ///   The property view model.          
    /// </summary>
    public class PropertyViewModel : BindableBase
    {
        /// <summary>
        /// The account balance.
        /// </summary>
        private double? accountBalance;

        /// <summary>
        /// The has maintenance.
        /// </summary>
        private bool hasMaintenance;

        /// <summary>
        /// The lease account number.
        /// </summary>
        private string leaseAccountNumber;

        /// <summary>
        /// The full lease address.
        /// </summary>
        private string leaseAddress;

        /// <summary>
        /// The lease unit.
        /// </summary>
        private string leaseUnit;

        /// <summary>
        /// The number of jobs.
        /// </summary>
        private int numberOfJobs;

        /// <summary>
        /// The lease identifier.
        /// </summary>
        private Guid leaseId;

        /// <summary>
        /// The lease property identifier.
        /// </summary>
        private Guid leasePropertyId;

        /// <summary>
        /// Gets or sets the account balance.
        /// </summary>
        public double? AccountBalance
        {
            get
            {
                return this.accountBalance;
            }

            set
            {
                this.SetProperty(ref this.accountBalance, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether has maintenance.
        /// </summary>
        public bool HasMaintenance
        {
            get
            {
                return this.hasMaintenance;
            }

            set
            {
                this.SetProperty(ref this.hasMaintenance, value);
            }
        }

        /// <summary>
        /// Gets or sets the lease account number.
        /// </summary>
        public string LeaseAccountNumber
        {
            get
            {
                return this.leaseAccountNumber;
            }

            set
            {
                this.SetProperty(ref this.leaseAccountNumber, value);
            }
        }

        /// <summary>
        /// Gets or sets the full lease address.
        /// </summary>
        public string LeaseAddress
        {
            get
            {
                return this.leaseAddress;
            }

            set
            {
                this.SetProperty(ref this.leaseAddress, value);
            }
        }

        /// <summary>
        /// Gets or sets the lease identifier.
        /// </summary>
        /// <value>The lease identifier.</value>
        public Guid LeaseId
        {
            get => this.leaseId;

            set
            {
                this.SetProperty(ref this.leaseId, value);
            }
        }

        /// <summary>
        /// Gets or sets the lease property identifier.
        /// </summary>
        /// <value>The lease property identifier.</value>
        public Guid LeasePropertyId
        {
            get => this.leasePropertyId;

            set
            {
                this.SetProperty(ref this.leasePropertyId, value);
            }
        }

        /// <summary>
        /// Gets or sets the lease unit.
        /// </summary>
        public string LeaseUnit
        {
            get
            {
                return this.leaseUnit;
            }

            set
            {
                this.SetProperty(ref this.leaseUnit, value);
            }
        }

        /// <summary>
        /// Gets or sets the number of jobs.
        /// </summary>
        public int NumberOfJobs
        {
            get
            {
                return this.numberOfJobs;
            }

            set
            {
                this.SetProperty(ref this.numberOfJobs, value);
            }
        }
    }
}