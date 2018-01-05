// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISettingsFacade.cs" company="">
//   
// </copyright>
// <summary>
//   The SettingsFacade interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Facades
{
    using CustomerPortal.Facade.Models;

    /// <summary>The SettingsFacade interface.</summary>
    public interface ISettingsFacade
    {
        /// <summary>The delete all.</summary>
        void DeleteAll();

        /// <summary>The get authorized facade request model.</summary>
        /// <returns>The <see cref="AuthorizedFacadeRequestModel" />.</returns>
        AuthorizedFacadeRequestModel GetAuthorizedFacadeRequestModel();

        /// <summary>The get settings.</summary>
        /// <returns>The <see cref="SettingsModel" />.</returns>
        SettingsModel GetSettings();

        /// <summary>The save settings.</summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The <see cref="SettingsModel"/>.</returns>
        SettingsModel SaveSettings(SettingsModel settings);
    }
}