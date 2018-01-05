using System;
using System.Threading.Tasks;
using CustomerPortal.Common;
using CustomerPortal.Facade.Facades;
using CustomerPortalApp.ViewModels;
using Microsoft.Practices.Unity;
using Prism.Navigation;
using Prism.Services;
using Xunit;
namespace CustomerPortal.Test
{
	public class ContactPageTests
	{
		IUnityContainer container = new UnityContainer();
		public ContactPageTests()
		{
			container.InitializeContainer();
			Xamarin.Forms.Mocks.MockForms.Init();
			SetupHelper.InitializeMapper();
		}

		/// <summary>
		/// Contacts the can make phone call pass.
		/// </summary>
		[Fact]
		public void Contact_CanMakePhoneCall_Pass()
		{
			var vm = new ContactPageViewModel(this.container.Resolve<IPageDialogService>(),
			                                  this.container.Resolve<IAuthenticationFacade>());
			vm.MakePhoneCall.Execute("+4498239823982389");

			Assert.NotNull(vm);
		}

		[Fact]
		public void Contact_CanSendAMessage_Pass()
		{
			var vm = new ContactPageViewModel(this.container.Resolve<IPageDialogService>(),
								  this.container.Resolve<IAuthenticationFacade>());
			vm.SendEmail.Execute("test@test.com");

			Assert.NotNull(vm);
		}
	}
}
