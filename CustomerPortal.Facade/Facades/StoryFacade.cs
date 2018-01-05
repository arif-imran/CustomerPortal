// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StoryFacade.cs" company="">
//   
// </copyright>
// <summary>
//   The story facade.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Facades
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CustomerPortal.Common;
    using CustomerPortal.DataAccess.ApiWrapper;
    using CustomerPortal.DataAccess.Model;
    using CustomerPortal.Facade.Helpers;
    using CustomerPortal.Facade.Models;

    using Grosvenor.Mobile.Common.Utils;

    using Story = CustomerPortal.Facade.Models.Story;

    /// <summary>The story facade.</summary>
    public class StoryFacade : IStoryFacade
    {
        /// <summary>The authentication wrapper.</summary>
        private readonly IAuthenticationHelperWrapper authWrapper;

        /// <summary>The story API.</summary>
        private readonly IStoryApiWrapper storyApi;

        /// <summary>Initializes a new instance of the <see cref="StoryFacade"/> class.</summary>
        /// <param name="storyApi">The story API.</param>
        /// <param name="authWrapper">The authentication wrapper.</param>
        public StoryFacade(IStoryApiWrapper storyApi, IAuthenticationHelperWrapper authWrapper)
        {
            this.storyApi = storyApi;
            this.authWrapper = authWrapper;
        }

        /// <summary>The get stories.</summary>
        /// <param name="model">The model.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<BaseFacadeResponseModel<GetStoriesResponseModel>> GetStories(
            AuthorizedPaginatedFacadeRequestModel model)
        {
            var apiModel = new GetStoriesApiRequestModel
                               {
                                   NumberOfItems = model.Paging.NumberItems,
                                   PageToGet = model.Paging.PageToGet,
                                   StoryTypes =
                                       model.QueryParameters.GetValue(
                                           MagicStrings.StoryTypes),
                                   TagList =
                                       model.QueryParameters.GetValue(MagicStrings.TagList),
                                   FilterByLocation = (bool)model.QueryParameters.GetValue(
                                       MagicStrings.FilterByLocation,
                                       ListExtensions.DictReturnType.Boolean)
                               };

            // try api call with access token
            var runner = await this.authWrapper.TraverseReauth(
                             () => this.storyApi.GetStories(
                                 model.AccessToken,
                                 apiModel.StoryTypes,
                                 apiModel.TagList,
                                 apiModel.PageToGet,
                                 apiModel.NumberOfItems,
                                 apiModel.FilterByLocation),
                             model.RefreshToken);

            // generic runner response that sets up the return object
            var runnerResponse = await new ApiRunnerResponseHelper().ReturnRunnerResponse(
                                     runner,
                                     new GetStoriesResponseModel(),
                                     new GetStoriesApiResponseModel());

            var mappedFacadeResponse =
                runnerResponse.FacadeResponseModel as BaseFacadeResponseModel<GetStoriesResponseModel>;

            // here we need to translate the api content response into the UI response
            if (runnerResponse.ApiContentResponseModelContent != null)
            {
                var apiResponse = runnerResponse.ApiContentResponseModelContent as GetStoriesApiResponseModel;
                var stories = new List<Story>();
                if (apiResponse != null)
                {
                    foreach (var story in apiResponse.Stories)
                    {
                        stories.Add(
                            new Story
                                {
                                    Id = story.Id,
                                    Content = story.HtmlContent,
                                    Category = story.Category,
                                    DateCreated = story.DateCreated,
                                    DateModified = story.DateModified,
                                    ImageAlt = story.ImageAlt,
                                    ImageUrl = story.ImageUrl,
                                    StoryFormat = story.StoryFormat,
                                    StoryUrl = story.StoryUrl,
                                    Tags = story.Tags.Select(x => x.Tag).ToList(),
                                    Title = story.Title,
                                    Description = story.Description
                                });
                    }

                    if (mappedFacadeResponse != null)
                    {
                        mappedFacadeResponse.Content =
                            new GetStoriesResponseModel
                                {
                                    Stories = stories,
                                    TotalNumberOfItems = apiResponse.TotalNumberOfItems
                                };
                    }
                }
            }

            return mappedFacadeResponse;
        }
    }
}