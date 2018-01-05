// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthenticatedHttpClientHandler.cs" company="">
//   
// </copyright>
// <summary>
//   The authenticated http client handler.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>The authenticated http client handler.</summary>
    public class AuthenticatedHttpClientHandler : HttpClientHandler
    {
        /// <summary>The _access token.</summary>
        private readonly string accessToken;

        /// <summary>Initializes a new instance of the <see cref="AuthenticatedHttpClientHandler"/> class.</summary>
        /// <param name="accessToken">The access token.</param>
        public AuthenticatedHttpClientHandler(string accessToken = "")
        {
            this.accessToken = accessToken;
        }

        /// <summary>The send async.</summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            if (!string.IsNullOrWhiteSpace(this.accessToken))
                request.Headers.Add(
                    "Authorization",
                    new AuthenticationHeaderValue("Bearer", this.accessToken).ToString());

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}