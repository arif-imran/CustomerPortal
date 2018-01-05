using System;
using Prism.Mvvm;
namespace CustomerPortalApp.ViewModels
{
	public class OfferViewModel : BindableBase
	{
		public string Title { get; set; }
		public string Description
		{
			get;
			set;
		}
		public string ImageURL
		{
			get;
			set;
		}
	}
	
}
