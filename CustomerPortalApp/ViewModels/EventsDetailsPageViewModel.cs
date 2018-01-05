using System;
using CustomerPortal.Facade.Facades;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace CustomerPortalApp.ViewModels
{
    using System.Text.RegularExpressions;
    using CustomerPortalApp.Styles;

    public class EventsDetailsPageViewModel : NavigationBaseViewModel
    {
        /// <summary>
        /// The html.
        /// </summary>
        private string html;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CustomerPortalApp.ViewModels.EventsDetailsPageViewModel"/> class.
        /// </summary>
        /// <param name="dialogService">Dialog service.</param>
        /// <param name="navigationService">Navigation service.</param>
        /// <param name="authenticationFacade">Authentication facade.</param>
        public EventsDetailsPageViewModel(IPageDialogService dialogService,
          INavigationService navigationService,
          IAuthenticationFacade authenticationFacade)
          : base(dialogService, authenticationFacade)
        {
            
        }

		/// <summary>
		/// Gets or sets the html.
		/// </summary>
		/// <value>The html.</value>
		public string Html
		{
			get { return this.html; }
			set { this.SetProperty(ref this.html, value); }
		}

        /// <summary>
        /// Ons the navigated to.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            string content = parameters["Content"].ToString();

            // 1st Approach
            //content = content.Replace("src=\"/", "src=\"http://www.grosvenorlondon.com/");

            // 2nd Approach
            var matchString = Regex.Matches(content, "<img.+?src=\"(.+?)\".+?/?>", RegexOptions.IgnoreCase);
            foreach (Match match in matchString)
            {
                if (!match.Groups[1].Value.Contains("http"))
                {
                    content = content.Replace(match.Groups[1].Value, "http://www.grosvenorlondon.com" + match.Groups[1].Value);
                }
            }

            this.Html = @"<html>
                            <head>
                                <style>"+Styles.MayfairBelgravia+" "+Styles.UnsemanticBase+"</style>" +
                            "</head>" +
                            "<body>"+content+"</body>" +
                          "</html>";
        }
    }
}
