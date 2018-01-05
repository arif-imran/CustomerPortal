// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SupportPageViewModel.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   SupportPageViewModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Services;
using System.Collections.ObjectModel;
using CustomerPortal.Facade.Facades;

namespace CustomerPortalApp.ViewModels
{

    /// <summary>
    /// Support page view model.
    /// </summary>
    public class SupportPageViewModel : NavigationBaseViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:CustomerPortalApp.ViewModels.HomePageViewModel"/> class.
        /// </summary>
        /// <param name="dialogService">Dialog service.</param>
        public ObservableCollection<GridEntry> FAQSections { get; set; }
		private ObservableCollection<string> _faqItems;
		public ObservableCollection<string> FAQItems
		{
			get { return _faqItems; }
			set { SetProperty(ref _faqItems, value); }
		}
        public SupportPageViewModel(IPageDialogService dialogService, IAuthenticationFacade authenticationFacade) : base(dialogService, authenticationFacade)
        {
            this.Title = "Support Page";
			PopulateFakeFAQSections();
        }

		void PopulateFakeFAQSections()
		{
			FAQSections = new ObservableCollection<GridEntry>();
			FAQSections.Add(new GridEntry() { ImagePath = "http://customerportaldev.grosvenor.com/images/content/Freehold-lease-management.jpg", Title = "Management Schemes" });
			FAQSections.Add(new GridEntry() { ImagePath = "http://customerportaldev.grosvenor.com/images/content/New-tenant.jpg", Title = "New tenant information" });
			FAQSections.Add(new GridEntry() { ImagePath = "http://customerportaldev.grosvenor.com/images/content/Payment.jpg", Title = "Payment enquiries" });
			FAQSections.Add(new GridEntry() { ImagePath = "http://customerportaldev.grosvenor.com/images/content/Maintenance-enquiries.jpg", Title = "Maintenance enquiry" });
			FAQSections.Add(new GridEntry() { ImagePath = "http://customerportaldev.grosvenor.com/images/content/Grosvenor-connect.jpg", Title = "Grosvenor Connect general enquiry" });
			FAQSections.Add(new GridEntry() { ImagePath = "http://customerportaldev.grosvenor.com/images/content/Parking-gardens.jpg", Title = "Parking & Gardens" });
			FAQSections.Add(new GridEntry() { ImagePath = "http://customerportaldev.grosvenor.com/images/content/General-enquiries.jpg", Title = "General enquries" });
			FAQSections.Add(new GridEntry() { ImagePath = "http://customerportaldev.grosvenor.com/images/content/Helpful-documents-2.jpg", Title = "Helpful documents" });
			FAQSections.Add(new GridEntry() { ImagePath = "http://customerportaldev.grosvenor.com/images/content/Lease-enquiries.jpg", Title = "Lease enquiry" });

			FAQItems = new ObservableCollection<string>();
			FAQItems.Add("FAQ Question 1?");
			FAQItems.Add("FAQ Question 2?");
			FAQItems.Add("FAQ Question 3?");
			FAQItems.Add("FAQ Question 4?");
			FAQItems.Add("FAQ Question 5?");

		}
}
}
