// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStoryApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The StoryApiWrapper interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Refit;

    /// <summary>The StoryApiWrapper interface.</summary>
    public interface IStoryApiWrapper
    {
        /// <summary>The get stories.</summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="storyTypes">The story types.</param>
        /// <param name="tagsList">The tags list.</param>
        /// <param name="pageToGet">The page to get.</param>
        /// <param name="numberOfItems">The number of items.</param>
        /// <param name="filterByLocation">The filter by location.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        [Get("/StoryApi/Stories")]
        [Headers("Accept: application/json", "Content-Type: application/json")]
        Task<HttpResponseMessage> GetStories(
            string accessToken,
            string storyTypes,
            string tagsList,
            int pageToGet,
            int numberOfItems,
            bool filterByLocation);

        /// <summary>The get story.</summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="storyId">The story id.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        [Get("/StoryApi/Story")]
        [Headers("Accept: application/json", "Content-Type: application/json")]
        Task<HttpResponseMessage> GetStory(string accessToken, Guid storyId);
    }
}