using System;
using CustomerPortal.Common;
using Prism.Commands;
using Prism.Mvvm;

namespace CustomerPortalApp
{
    public class NavigationItemViewModel : BindableBase
    {
        /// <summary>
        /// The name.
        /// </summary>
        private string name;

        /// <summary>
        /// The lease identifier.
        /// </summary>
        private Guid leaseId;

        /// <summary>
        /// The navigation URL.
        /// </summary>
        private string navigationUrl;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                SetProperty(ref this.name, value);
            }
        }

        /// <summary>
        /// Gets or sets the navigation URL.
        /// </summary>
        /// <value>The navigation URL.</value>
        public string NavigationUrl
        {
            get
            {
                return this.navigationUrl;
            }
            set
            {
                SetProperty(ref this.navigationUrl, value);
            }
        }

        /// <summary>
        /// Gets or sets the lease identifier.
        /// </summary>
        /// <value>The lease identifier.</value>
        public Guid LeaseId
        {
            get
            {
                return this.leaseId;
            }
            set
            {
                SetProperty(ref this.leaseId, value);
            }
        }

        /// <summary>
        /// Gets or sets the item tapped command.
        /// </summary>
        /// <value>The item tapped command.</value>
		public DelegateCommand<NavigationItemViewModel> ItemTappedCommand { get; set; }

    }

}
