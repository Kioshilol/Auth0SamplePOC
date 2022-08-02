using Auth0POC.Services;
using System;
using Xamarin.Forms;

namespace Auth0POC
{
    public partial class MainPage : ContentPage
    {
        readonly IAuthService _authenticationService;

        public MainPage()
        {
            InitializeComponent();

            AppleButton.IsVisible = Device.RuntimePlatform == Device.iOS;

            _authenticationService = DependencyService.Get<IAuthService>();
        }

        private void OnContinueWithFacebookClicked(object _, EventArgs __)
        {
            _ = _authenticationService.Login(Constants.ConnectionName.Facebook);
        }

        private void OnContinueGoogleClicked(object _, EventArgs __)
        {
            _ = _authenticationService.Login(Constants.ConnectionName.Google);
        }

        private void OnContinueWithAppleClicked(object sender, EventArgs e)
        {
            _ = _authenticationService.Login(Constants.ConnectionName.Apple);
        }

        private void OnLogoutClicked(object sender, EventArgs e)
        {
            _ = _authenticationService.Logout();
        }
    }
}
