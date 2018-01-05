// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProfilePageViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   The profile page view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortalApp.ViewModels
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using CustomerPortal.Facade.Facades;
    using CustomerPortal.Facade.Models;

    using Grosvenor.Mobile.Common;
    using Grosvenor.Mobile.Common.Utils;
	using Grosvenor.Mobile.DataAccess.Services;
    using Prism.Commands;
    using Prism.Navigation;
    using Prism.Services;

    using Xamarin.Forms;

    /// <summary>The profile page view model.</summary>
    public class ProfilePageViewModel : NavigationBaseViewModel
    {
        /// <summary>The account facade.</summary>
        private readonly IAccountFacade accountFacade;

        /// <summary>The keychain service.</summary>
        private readonly IKeychainService keychainService;

        /// <summary>The country.</summary>
        private string country;

        /// <summary>The description.</summary>
        private string description;

        /// <summary>The email.</summary>
        private string email;

        /// <summary>The first name.</summary>
        private string firstName;

        /// <summary>The is receive email.</summary>
        private bool isReceiveEmail;

        /// <summary>The last name.</summary>
        private string lastName;

        /// <summary>The password.</summary>
        private string password;

        /// <summary>The postcode.</summary>
        private string postcode;

        /// <summary>The street.</summary>
        private string street;

        /// <summary>The town.</summary>
        private string town;

        /// <summary>Initializes a new instance of the <see cref="ProfilePageViewModel"/> class.</summary>
        /// <param name="dialogService">The dialog service.</param>
        /// <param name="authenticationFacade">The authentication facade.</param>
        /// <param name="accountFacade">The account Facade.</param>
        /// <param name="keychainService">The settings Facade.</param>
        public ProfilePageViewModel(
            IPageDialogService dialogService,
            IAuthenticationFacade authenticationFacade,
            IAccountFacade accountFacade,
            IKeychainService keychainService, 
            INavigationService navigationService)
            : base(dialogService, authenticationFacade, navigationService)
        {
            this.accountFacade = accountFacade;
            this.keychainService = keychainService;
        }

        /// <summary>Gets or sets the country.</summary>
        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.SetProperty(ref this.country, value);
            }
        }

        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.SetProperty(ref this.description, value);
            }
        }

        /// <summary>Gets or sets the email.</summary>
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.SetProperty(ref this.email, value);
            }
        }

        /// <summary>Gets or sets the first name.</summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.SetProperty(ref this.firstName, value);
            }
        }

        /// <summary>Gets or sets a value indicating whether is receive email.</summary>
        public bool IsReceiveEmail
        {
            get
            {
                return this.isReceiveEmail;
            }

            set
            {
                this.SetProperty(ref this.isReceiveEmail, value);
            }
        }

        /// <summary>Gets or sets the last name.</summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.SetProperty(ref this.lastName, value);
            }
        }

        /// <summary>Gets or sets the password.</summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.SetProperty(ref this.password, value);
            }
        }

        /// <summary>Gets or sets the postcode.</summary>
        public string Postcode
        {
            get
            {
                return this.postcode;
            }

            set
            {
                this.SetProperty(ref this.postcode, value);
            }
        }

        /// <summary>Gets or sets the street.</summary>
        public string Street
        {
            get
            {
                return this.street;
            }

            set
            {
                this.SetProperty(ref this.street, value);
            }
        }

        /// <summary>Gets or sets the city.</summary>
        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                this.SetProperty(ref this.town, value);
            }
        }

        /// <summary>The on navigated to.</summary>
        /// <param name="parameters">The parameters.</param>
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            this.ExecuteAsyncTask(this.LoadMyProfile).Forget();
        }

        /// <summary>The load my profile.</summary>
        /// <returns>The <see cref="Task" />.</returns>
        private async Task LoadMyProfile()
        {
            // call account facade to get Profile Details.            
			var myProfile = await this.accountFacade.MyProfile(this.keychainService.GetAuthorizedKeychainRequestModel());

            // map my profile to view model fields.
            Device.BeginInvokeOnMainThread(() => { this.MapViewModel(myProfile); });
        }

        /// <summary>The map view model.</summary>
        /// <param name="myProfile">The my profile.</param>
        private void MapViewModel(BaseFacadeResponseModel<MyProfileResponseModel> myProfile)
        {
            var profile = myProfile?.Content?.MyProfile;
            if (profile == null)
            {
                return;
            }

            this.Street = $"{profile.Address1}{Environment.NewLine}{profile.Address2}";
            this.Town = profile.Town;
            this.Country = profile.Country;
            this.Postcode = profile.Postcode;
            this.Email = profile.EmailAddress;
            this.FirstName = profile.FirstName;
            this.LastName = profile.LastName;
            this.Password = profile.Postcode;
        }
    }
}