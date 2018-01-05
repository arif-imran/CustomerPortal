// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseFacadeRequestModelWithContent.cs" company="">
//   
// </copyright>
// <summary>
//   The base facade request model with content.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    /// <summary>The base facade request model with content.</summary>
    /// <typeparam name="T"></typeparam>
    public class BaseFacadeRequestModelWithContent<T> : BaseFacadeRequestModel
    {
        /// <summary>Gets or sets the content.</summary>
        public T Content { get; set; }
    }
}