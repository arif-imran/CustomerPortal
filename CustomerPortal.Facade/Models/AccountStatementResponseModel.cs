// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountStatementResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The account statement response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The account statement response model.
    /// </summary>
    public class AccountStatementResponseModel
    {
        /// <summary>
        /// Gets or sets the account statement entries.
        /// </summary>
        public IEnumerable<AccountStatementEntry> AccountStatementEntries { get; set; }

        /// <summary>
        /// Gets or sets the total number of items.
        /// </summary>
        public int TotalNumberOfItems { get; set; }
    }
}