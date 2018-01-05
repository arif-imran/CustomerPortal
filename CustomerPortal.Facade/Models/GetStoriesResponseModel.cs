// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetStoriesResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The get stories response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System.Collections.Generic;

    using CustomerPortal.DataAccess.Model;

    /// <summary>The get stories response model.</summary>
    public class GetStoriesResponseModel
    {
        /// <summary>Gets or sets the stories.</summary>
        public List<Story> Stories { get; set; }

        /// <summary>Gets or sets the total number of items.</summary>
        public int TotalNumberOfItems { get; set; }
    }
}