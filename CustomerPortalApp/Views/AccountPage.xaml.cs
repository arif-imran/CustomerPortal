// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AccountPage.xaml.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   AccountPage.xaml
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using CustomerPortalApp.Controls;
using Xamarin.Forms;

namespace CustomerPortalApp.Views
{
    public partial class AccountPage : ContentPage
    {
        public AccountPage()
        {
            InitializeComponent();
			this.PropertyCarousel.DataTemplate = new DataTemplate(typeof(AccountCarousel));
        }
    }
}

