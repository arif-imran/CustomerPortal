// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OutstandingBalanceApiResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The outstanding balance api response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System.Collections.Generic;

    /// <summary>
    ///     The outstanding balance api response model.
    /// </summary>
    public class OutstandingBalanceApiResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutstandingBalanceApiResponseModel"/> class. 
        ///     Initializes a new instance of the
        ///     <see cref="OutstandingBalanceApiResponseModel"/>
        ///     class.
        /// </summary>
        public OutstandingBalanceApiResponseModel()
        {
            this.StatementEntries = new List<CurrentBalance>();
        }

        /// <summary>
        ///     Gets or sets the statement entries.
        /// </summary>
        public List<CurrentBalance> StatementEntries { get; set; }
    }
}