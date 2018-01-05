// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IAuthenticationFacade.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   IAuthenticationFacade
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;
using CustomerPortal.Facade.Models;

namespace CustomerPortal.Facade.Facades
{
    /// <summary>
    /// Authentication facade.
    /// </summary>
    public interface IAuthenticationFacade
    {
        /// <summary>
        /// Logout this instance.
        /// </summary>
        void Logout();

        /// <summary>
        /// Gets the current user.
        /// </summary>
        /// <value>The current user.</value>
        Models.IdentityModel CurrentUser { get; }

        /// <summary>
        /// Login the specified model.
        /// </summary>
        /// <returns>The login.</returns>
        /// <param name="model">Model.</param>
        Task<BaseFacadeResponseModel<LoginResponseModel>> Login(BaseFacadeRequestModelWithContent<LoginRequestModel> model);
    }
}