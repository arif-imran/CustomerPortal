// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizedPaginatedFacadeRequestModel.cs" company="">
//   
// </copyright>
// <summary>
//   The authorized paginated facade request model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System.Collections.Generic;

    /// <summary>The authorized paginated facade request model.</summary>
    public class AuthorizedPaginatedFacadeRequestModel
    {
        /// <summary>Initializes a new instance of the <see cref="AuthorizedPaginatedFacadeRequestModel" /> class.</summary>
        public AuthorizedPaginatedFacadeRequestModel()
        {
            this.QueryParameters = new List<KeyValuePair<string, object>>();
        }

        /// <summary>Gets or sets the access token.</summary>
        public string AccessToken { get; set; }

        /// <summary>Gets or sets the paging.</summary>
        public PaginationConfigModel Paging { get; set; }

        /// <summary>Gets or sets the query parameters.</summary>
        public List<KeyValuePair<string, object>> QueryParameters { get; set; }

        /// <summary>Gets or sets the refresh token.</summary>
        public string RefreshToken { get; set; }
    }
}