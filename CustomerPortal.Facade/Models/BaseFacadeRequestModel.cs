// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseFacadeRequestModel.cs" company="">
//   
// </copyright>
// <summary>
//   The base facade request model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System.Collections.Generic;

    /// <summary>The base facade request model.</summary>
    public class BaseFacadeRequestModel
    {
        /// <summary>Initializes a new instance of the <see cref="BaseFacadeRequestModel"/> class.</summary>
        public BaseFacadeRequestModel()
        {
            this.QueryParameters = new List<KeyValuePair<string, object>>();
        }

        /// <summary>Gets or sets the query parameters.</summary>
        public List<KeyValuePair<string, object>> QueryParameters { get; set; }
    }
}