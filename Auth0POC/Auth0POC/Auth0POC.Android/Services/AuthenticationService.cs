using Auth0.OidcClient;
using Auth0POC.Droid.Services;
using Auth0POC.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(AuthenticationService))]
namespace Auth0POC.Droid.Services
{
    public class AuthenticationService : IAuthService
    {
        private readonly Auth0Client _client;

        public AuthenticationService()
        {
            var options = new Auth0ClientOptions
            {
                Domain = AndroidConstants.Domain,
                ClientId = Constants.ClientId,
            };

            _client = new Auth0Client(options);
        }

        public async Task Login(string connectionName)
        {
            var extraParameters = new Dictionary<string, string>();
            extraParameters.Add("connection", connectionName);

            var loginResult = await _client.LoginAsync(extraParameters);

            if (!loginResult.IsError)
            {
                Debug.WriteLine($"name: {loginResult.User.FindFirst(c => c.Type == "name")?.Value}");
                Debug.WriteLine($"email: {loginResult.User.FindFirst(c => c.Type == "email")?.Value}");
            }
        }

        public async Task Logout()
        {
            var qwe = await _client.LogoutAsync();
        }
    }
}