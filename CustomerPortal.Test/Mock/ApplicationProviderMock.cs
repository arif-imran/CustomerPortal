using System.Reflection;
using System.Threading.Tasks;
using Prism.Common;
using Xamarin.Forms;

namespace CustomerPortal.Test
{
	public class ApplicationProviderMock : IApplicationProvider
	{
		public ApplicationProviderMock()
		{
			MainPage = new ContentPage()
			{
				Title = "MainPage"
			};
		}

		public ApplicationProviderMock(Page page)
		{
			MainPage = page;
		}

		public Page MainPage { get; set; }
	}
}