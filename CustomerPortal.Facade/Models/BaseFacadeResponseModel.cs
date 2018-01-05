// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseFacadeResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The base facade response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System.Net;

    /// <summary>The base facade response model.</summary>
    /// <typeparam name="T"></typeparam>
    public class BaseFacadeResponseModel<T>
    {
        /// <summary>Gets or sets the access token.</summary>
        public string AccessToken { get; set; }

        /// <summary>Gets or sets the content.</summary>
        public T Content { get; set; }

        /// <summary>Gets or sets the message.</summary>
        public string Message { get; set; }

        /// <summary>Gets or sets the refresh token.</summary>
        public string RefreshToken { get; set; }

        /// <summary>Gets a value indicating whether response has content.</summary>
        public bool ResponseHasContent
        {
            get
            {
                return this.Content != null;
            }
        }

        /// <summary>Gets or sets the status code.</summary>
        public HttpStatusCode StatusCode { get; set; }
    }
}