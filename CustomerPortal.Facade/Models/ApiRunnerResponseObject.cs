// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiRunnerResponseObject.cs" company="">
//   
// </copyright>
// <summary>
//   The api runner response object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    /// <summary>
    /// The api runner response object.
    /// </summary>
    public class ApiRunnerResponseObject
    {
        /// <summary>
        /// Gets or sets the api content response model content.
        /// </summary>
        public object ApiContentResponseModelContent { get; set; }

        /// <summary>
        /// Gets or sets the facade response model.
        /// </summary>
        public object FacadeResponseModel { get; set; }
    }
}