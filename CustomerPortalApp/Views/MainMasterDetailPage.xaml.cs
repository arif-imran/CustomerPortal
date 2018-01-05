// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MainMasterDetailPage.xaml.cs" company="Grosvenor">
// //   ${CopyrightHolder}
// // </copyright>
// // <summary>
// //   MainMasterDetailPage.xaml
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using Prism.Navigation;
using Xamarin.Forms;

namespace CustomerPortalApp.Views
{
    public partial class MainMasterDetailPage : MasterDetailPage, IMasterDetailPageOptions
    {
        public MainMasterDetailPage()
        {
            InitializeComponent();

            if (this.Master is NavigationPage)
            {
                var master = this.Master as NavigationPage;

                if (master.CurrentPage != null)
                {
                    NavigationPage.SetHasNavigationBar(master.CurrentPage, false);
                }
            }
        }

        public bool IsPresentedAfterNavigation => Device.Idiom != TargetIdiom.Phone;



    }
}

