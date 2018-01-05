// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseApiResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The base api response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System.Net;

    /// <summary>The base api response model.</summary>
    /// <typeparam name="T"></typeparam>
    public class BaseApiResponseModel<T>
    {
        /// <summary>Gets or sets the content.</summary>
        public T Content { get; set; }

        /// <summary>Gets or sets the message.</summary>
        public string Message { get; set; }

        /// <summary>Gets or sets the status code.</summary>
        public HttpStatusCode StatusCode { get; set; }
    }
}