// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAccountFacade.cs" company="">
//   
// </copyright>
// <summary>
//   The AccountFacade interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Facades
{
	using System.Threading.Tasks;

	using CustomerPortal.Facade.Models;
	using Grosvenor.Mobile.DataAccess.Model;

	/// <summary>
	///     The AccountFacade interface.
	/// </summary>
	public interface IAccountFacade
	{
		/// <summary>The my profile.</summary>
		/// <param name="model">The model.</param>
		/// <returns>The <see cref="Task"/>.</returns>
		Task<BaseFacadeResponseModel<MyProfileResponseModel>> MyProfile(AuthorizedKeychainRequestModel model);
	}
}
