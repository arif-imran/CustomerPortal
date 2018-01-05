// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetStoriesApiRequestModel.cs" company="">
//   
// </copyright>
// <summary>
//   The get stories api request model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    /// <summary>The get stories API request model.</summary>
    public class GetStoriesApiRequestModel
    {
        /// <summary>Gets or sets a value indicating whether filter by location.</summary>
        public bool FilterByLocation { get; set; }

        /// <summary>Gets or sets the number of items.</summary>
        public int NumberOfItems { get; set; }

        /// <summary>Gets or sets the page to get.</summary>
        public int PageToGet { get; set; }

        /// <summary>Gets or sets the story types.</summary>
        public string StoryTypes { get; set; }

        /// <summary>Gets or sets the tag list.</summary>
        public string TagList { get; set; }
    }
}