// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetLeaseInfoByLeaseIdApiResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The get lease info by lease id api response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    /// <summary>
    /// The get lease info by lease id api response model.
    /// </summary>
    public class GetLeaseInfoByLeaseIdApiResponseModel
    {
        /// <summary>
        /// Gets or sets the lease information.
        /// </summary>
        public LeaseDetails LeaseInformation { get; set; }
    }
}