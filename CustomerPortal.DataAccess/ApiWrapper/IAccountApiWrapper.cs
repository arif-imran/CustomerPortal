// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAccountApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The Account API Wrapper interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper
{
    using System.Net.Http;
    using System.Threading.Tasks;

    using Refit;

    /// <summary>The Account API Wrapper interface.</summary>
    public interface IAccountApiWrapper
    {
        /// <summary>The my profile.</summary>
        /// <param name="accessToken">The access token.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        [Get("/accountapi/myprofile")]
        [Headers("Accept: application/json", "Content-Type: application/json")]
        Task<HttpResponseMessage> MyProfile(string accessToken);
    }
}