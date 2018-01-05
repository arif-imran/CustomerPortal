// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountStatementApiResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The account statement api response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// The account statement api response model.
    /// </summary>
    public class AccountStatementApiResponseModel
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