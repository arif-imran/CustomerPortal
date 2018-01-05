// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StoryApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The story api wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    using CustomerPortal.Common;

    using Refit;

    /// <summary>The story API wrapper.</summary>
    public class StoryApiWrapper : IStoryApiWrapper
    {
        /// <summary>The get stories.</summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="type">The type.</param>
        /// <param name="tagsList">The tags list.</param>
        /// <param name="pageToGet">The page to get.</param>
        /// <param name="numberOfItems">The number of items.</param>
        /// <param name="filterByLocation">The filter by location.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<HttpResponseMessage> GetStories(
            string accessToken,
            string type,
            string tagsList,
            int pageToGet,
            int numberOfItems,
            bool filterByLocation)
        {
            var storyApi = RestService.For<IStoryApiWrapper>(
                new HttpClient(new AuthenticatedHttpClientHandler(accessToken))
                    {
                        BaseAddress = new Uri(
                            SharedConfig.ApiEndpoint)
                    });

            return await storyApi.GetStories(accessToken, type, tagsList, pageToGet, numberOfItems, filterByLocation);
        }

        /// <summary>The get story.</summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="storyId">The story id.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<HttpResponseMessage> GetStory(string accessToken, Guid storyId)
        {
            var storyApi = RestService.For<IStoryApiWrapper>(
                new HttpClient(new AuthenticatedHttpClientHandler(accessToken))
                    {
                        BaseAddress = new Uri(
                            SharedConfig.ApiEndpoint)
                    });

            return await storyApi.GetStory(accessToken, storyId);
        }
    }
}