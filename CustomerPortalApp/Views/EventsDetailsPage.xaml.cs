using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomerPortalApp.Views
{
    public partial class EventsDetailsPage : ContentPage
    {
        public EventsDetailsPage()
        {
            InitializeComponent();
        }
		
        void webOnNavigating(object sender, WebNavigatingEventArgs e)
		{
			LoadingIndicator.IsVisible = true;
		}

		void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
		{
            LoadingIndicator.IsVisible = false;
		}
    }
}
