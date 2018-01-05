// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetStoryResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The get story response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using CustomerPortal.DataAccess.Model;

    /// <summary>The get story response model.</summary>
    public class GetStoryResponseModel
    {
        /// <summary>Gets or sets the story.</summary>
        public Story Story { get; set; }
    }
}