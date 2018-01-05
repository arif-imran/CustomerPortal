// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetStoriesApiResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The get stories api response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System.Collections.Generic;

    /// <summary>The get stories API response model.</summary>
    public class GetStoriesApiResponseModel
    {
        /// <summary>Gets or sets the stories.</summary>
        public List<Story> Stories { get; set; }

        /// <summary>Gets or sets the total number of items.</summary>
        public int TotalNumberOfItems { get; set; }
    }
}