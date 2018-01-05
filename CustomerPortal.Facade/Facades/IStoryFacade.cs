// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStoryFacade.cs" company="">
//   
// </copyright>
// <summary>
//   The StoryFacade interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Facades
{
    using System.Threading.Tasks;

    using CustomerPortal.Facade.Models;

    /// <summary>The StoryFacade interface.</summary>
    public interface IStoryFacade
    {
        /// <summary>The get stories.</summary>
        /// <param name="model">The model.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<BaseFacadeResponseModel<GetStoriesResponseModel>> GetStories(AuthorizedPaginatedFacadeRequestModel model);
    }
}