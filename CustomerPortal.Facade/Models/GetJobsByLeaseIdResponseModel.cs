// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetJobsByLeaseIdResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The get jobs by lease id response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System.Collections.Generic;

    using CustomerPortal.DataAccess.Model;

    /// <summary>The get jobs by lease id response model.</summary>
    public class GetJobsByLeaseIdResponseModel
    {
        /// <summary>Gets or sets the jobs.</summary>
        public IEnumerable<Job> Jobs { get; set; }

        /// <summary>Gets or sets the total number of items.</summary>
        public int TotalNumberOfItems { get; set; }
    }
}