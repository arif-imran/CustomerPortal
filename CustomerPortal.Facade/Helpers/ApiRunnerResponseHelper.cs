// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiRunnerResponseHelper.cs" company="">
//   
// </copyright>
// <summary>
//   The api runner response helper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Helpers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    using CustomerPortal.DataAccess.Model;
    using CustomerPortal.Facade.Enums;
    using CustomerPortal.Facade.Models;

    using Newtonsoft.Json;

    /// <summary>The api runner response helper.</summary>
    public class ApiRunnerResponseHelper
    {
        /// <summary>The return runner response.</summary>
        /// <param name="runner">The runner.</param>
        /// <param name="responseModel">The response model.</param>
        /// <param name="apiResponseModel">The api response model.</param>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<ApiRunnerResponseObject> ReturnRunnerResponse<T2, T3>(
            ReauthenticationResponse<HttpResponseMessage> runner,
            T2 responseModel,
            T3 apiResponseModel)
        {
            if (runner.Result == ReauthenticationResult.Failure)
                return new ApiRunnerResponseObject
                           {
                               ApiContentResponseModelContent = null,
                               FacadeResponseModel =
                                   new BaseFacadeResponseModel<T2>
                                       {
                                           StatusCode =
                                               HttpStatusCode
                                                   .Unauthorized,
                                           Message =
                                               "Invalid security tokens"
                                       }
                           };

            var apiContentToReturn = false;

            var baseApiResponse = new BaseApiResponseModel<T3>();
            var facadeResponse =
                new BaseFacadeResponseModel<T2>
                    {
                        StatusCode = runner.Response.StatusCode,
                        Message = await runner.Response.Content.ReadAsStringAsync()
                    };

            try
            {
                if (facadeResponse.StatusCode == HttpStatusCode.OK
                    || facadeResponse.StatusCode == HttpStatusCode.Created
                    || facadeResponse.StatusCode == HttpStatusCode.ExpectationFailed)
                {
                    baseApiResponse.Content = JsonConvert.DeserializeObject<T3>(facadeResponse.Message);
                    apiContentToReturn = true;
                }
            }
            catch (Exception ex)
            {
                // TODO: log me
                facadeResponse.StatusCode = HttpStatusCode.InternalServerError;
                facadeResponse.Message = "Response failed deserialization";
            }

            // error handling - list of errors from response
            facadeResponse.AccessToken = runner.AccessToken;
            facadeResponse.RefreshToken = runner.RefreshToken;

            if (apiContentToReturn)
                return new ApiRunnerResponseObject
                           {
                               ApiContentResponseModelContent = baseApiResponse.Content,
                               FacadeResponseModel = facadeResponse
                           };

            return new ApiRunnerResponseObject { FacadeResponseModel = facadeResponse };
        }
    }
}