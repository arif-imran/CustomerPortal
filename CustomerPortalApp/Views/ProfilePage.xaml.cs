using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomerPortalApp.Views
{
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage()
		{
			InitializeComponent();
		}

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PopAsync(true);
        }
    }
}
