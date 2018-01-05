// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetLeaseInfoByLeaseIdResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The get lease info by lease id response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using CustomerPortal.DataAccess.Model;

    /// <summary>
    /// The get lease info by lease id response model.
    /// </summary>
    public class GetLeaseInfoByLeaseIdResponseModel
    {
        /// <summary>
        /// Gets or sets the lease information.
        /// </summary>
        public LeaseDetails LeaseInformation { get; set; }
    }
}