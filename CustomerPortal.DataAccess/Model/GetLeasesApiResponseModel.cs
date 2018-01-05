// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetLeasesApiResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The get leases api response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System.Collections.Generic;

    /// <summary>The get leases api response model.</summary>
    public class GetLeasesApiResponseModel
    {
        /// <summary>Initializes a new instance of the <see cref="GetLeasesApiResponseModel" /> class.</summary>
        public GetLeasesApiResponseModel()
        {
            this.Leases = new List<LeaseOverview>();
        }

        /// <summary>Gets or sets the leases.</summary>
        public List<LeaseOverview> Leases { get; set; }
    }
}