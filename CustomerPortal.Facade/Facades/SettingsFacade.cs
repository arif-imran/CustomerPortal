// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SettingsFacade.cs" company="">
//   
// </copyright>
// <summary>
//   Settings facade.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Facades
{
    using System.Linq;

    using CustomerPortal.DataAccess.Model;
    using CustomerPortal.Facade.Models;

    using Grosvenor.Mobile.DataAccess.Services;

    /// <summary>
    ///     Settings facade.
    /// </summary>
    public class SettingsFacade : ISettingsFacade
    {
        /// <summary>The data access service.</summary>
        private readonly IDataAccessService dataAccessService;

        /// <summary>The settings lock.</summary>
        private readonly object settingsLock = new object();

        /// <summary>Initializes a new instance of the <see cref="T:CustomerPortal.Facade.Facades.SettingsFacade"/> class.</summary>
        /// <param name="dataAccessService">Data access service.</param>
        public SettingsFacade(IDataAccessService dataAccessService)
        {
            this.dataAccessService = dataAccessService;
        }

        /// <summary>
        ///     Deletes all.
        /// </summary>
        public void DeleteAll()
        {
            var result = this.dataAccessService.DeleteAll<Settings>();
        }

        /// <summary>The get authorized facade request model.</summary>
        /// <returns>The <see cref="AuthorizedFacadeRequestModel"/>.</returns>
        public AuthorizedFacadeRequestModel GetAuthorizedFacadeRequestModel()
        {
            var settings = this.GetSettings();
            return new AuthorizedFacadeRequestModel
                       {
                           AccessToken = settings.AccessToken,
                           RefreshToken = settings.RefreshToken
                       };
        }

        /// <summary>
        ///     Gets the settings.
        /// </summary>
        /// <returns>The settings.</returns>
        public SettingsModel GetSettings()
        {
            lock (this.settingsLock)
            {
                return this.GetSettingsWithoutLock();
            }
        }

        /// <summary>Saves the settings.</summary>
        /// <returns>The settings.</returns>
        /// <param name="settingsModel">Settings model.</param>
        public SettingsModel SaveSettings(SettingsModel settingsModel)
        {
            lock (this.settingsLock)
            {
                // load existing Settings
                var existingSetttings = this.GetSettingsWithoutLock();

                // map to setting for data access.
                var setting = new Settings();

                if (existingSetttings != null) setting.Id = existingSetttings.Id;

                setting.AccessToken = settingsModel.AccessToken;
                setting.AccessTokenExpireDate = settingsModel.AccessTokenExpireDate;
                setting.Password = settingsModel.Password;
                setting.Username = settingsModel.Username;
                setting.RefreshToken = settingsModel.RefreshToken;

                settingsModel.Id = this.dataAccessService.Save(setting);

                return settingsModel;
            }
        }

        /// <summary>
        ///     Gets the settings without lock. This method should only be called from collision controlled lock.
        /// </summary>
        /// <returns>The settings without lock.</returns>
        private SettingsModel GetSettingsWithoutLock()
        {
            var settings = this.dataAccessService.GetAll<Settings>();

            if (settings == null || settings.Count == 0) return null;

            var setting = settings.FirstOrDefault();

            // todo add automapper
            // map to SettingsModel
            var result = new SettingsModel
                             {
                                 Username = setting.Username,
                                 Password = setting.Password,
                                 AccessToken = setting.AccessToken,
                                 AccessTokenExpireDate = setting.AccessTokenExpireDate,
                                 Id = setting.Id,
                                 RefreshToken = setting.RefreshToken
                             };

            return result;
        }
    }
}