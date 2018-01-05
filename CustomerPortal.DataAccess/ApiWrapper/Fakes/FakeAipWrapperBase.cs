// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FakeAipWrapperBase.cs" company="Grosvenor">
// //   
// // </copyright>
// // <summary>
// //   FakeAipWrapperBase
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper.Fakes
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    using CustomerPortal.DataAccess.Model;

    /// <summary>
    /// Fake aip wrapper base.
    /// </summary>
    public class FakeAipWrapperBase
    {
        /// <summary>
        /// Gets the fake response.
        /// </summary>
        /// <returns>The fake response.</returns>
        /// <param name="content">Content.</param>
        protected async Task<HttpResponseMessage> GetFakeResponse(string content)
        {
            await Task.Delay(100);

            var response = new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };

            byte[] byteArray = Encoding.UTF8.GetBytes(content);
            var stream = new MemoryStream(byteArray);

            response.Content = new StreamContent(stream, byteArray.Length);

            return response;
        }
    }
}