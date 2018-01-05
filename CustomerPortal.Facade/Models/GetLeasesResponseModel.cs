// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetLeasesResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The get leases response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System.Collections.Generic;

    using CustomerPortal.DataAccess.Model;

    /// <summary>The get leases response model.</summary>
    public class GetLeasesResponseModel
    {
        /// <summary>Gets or sets the leases.</summary>
        public List<LeaseOverview> Leases { get; set; }
    }
}