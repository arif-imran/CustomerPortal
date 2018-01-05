// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MainNavigationPage.xaml.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   MainNavigationPage.xaml
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using Xamarin.Forms;

namespace CustomerPortalApp.Views
{
    public partial class MainNavigationPage : NavigationPage
    {
        public MainNavigationPage()
        {
            InitializeComponent();

            var i = Navigation.NavigationStack;
        }
    }
}

