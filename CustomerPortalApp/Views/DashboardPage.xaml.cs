// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DashboardPage.xaml.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   DashboardPage.xaml
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using Xamarin.Forms;
using CustomerPortalApp.Controls;
using System;
using CustomerPortalApp.ViewModels;
using Prism.Navigation;

namespace CustomerPortalApp.Views
{
    public partial class DashboardPage : ContentPage, INavigationAware
    {
        public DashboardPage()
        {
            InitializeComponent();
			this.PropertyCarousel.DataTemplate = new DataTemplate(typeof(PropertyControl));
		}

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }


    }
}

