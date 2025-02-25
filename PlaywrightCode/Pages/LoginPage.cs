using System.Threading.Tasks;
using Microsoft.Playwright;

namespace SwagLabProject.PlaywrightCode.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;
        private readonly string _usernameField = "#user-name";
        private readonly string _passwordField = "#password";
        private readonly string _loginButton = "#login-button";

        public LoginPage(IPage page) => _page = page;

        public async Task EnterUsername(string username) => await _page.FillAsync(_usernameField, username);
        public async Task EnterPassword(string password) => await _page.FillAsync(_passwordField, password);
        public async Task ClickLogin() => await _page.ClickAsync(_loginButton);

        public async Task<bool> IsOnLoginPage() => _page.Url.Contains("saucedemo");
    }
}