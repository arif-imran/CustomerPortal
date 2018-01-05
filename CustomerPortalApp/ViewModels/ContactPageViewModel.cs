// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ContactPageViewModel.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   ContactPageViewModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Services;
using CustomerPortal.Facade.Facades;
using Xamarin.Forms;

namespace CustomerPortalApp.ViewModels
{

	/// <summary>
	/// Contact page view model.
	/// </summary>
	public class ContactPageViewModel : NavigationBaseViewModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:CustomerPortalApp.ViewModels.HomePageViewModel"/> class.
		/// </summary>
		/// <param name="dialogService">Dialog service.</param>
		public ContactPageViewModel(IPageDialogService dialogService, IAuthenticationFacade authenticationFacade) : base(dialogService, authenticationFacade)
		{
			this.Title = "Contact Page";
		}

		public DelegateCommand<string> MakePhoneCall => new DelegateCommand<string>(this.makePhoneCall);
		public DelegateCommand<string> SendEmail => new DelegateCommand<string>(this.sendEmail);
		private void makePhoneCall(string parameter)
		{
			Device.OpenUri(new Uri(string.Format("tel:{0}", parameter)));

		}
		private void sendEmail(string parameter)
		{
			Device.OpenUri(new Uri(string.Format("mailto:{0}", parameter)));
		}
	}

}
