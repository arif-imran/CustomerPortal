// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OutstandingBalanceResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The outstanding balance response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The outstanding balance response model.
    /// </summary>
    public class OutstandingBalanceResponseModel
    {
        /// <summary>
        /// Gets or sets the statement entries.
        /// </summary>
        public List<CurrentBalance> StatementEntries { get; set; }
    }
}