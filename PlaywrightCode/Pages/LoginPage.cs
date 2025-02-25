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

        public async Task EnterUsername(string username) => await _page.Locator(_usernameField).FillAsync(username);
        public async Task EnterPassword(string password) => await _page.Locator(_passwordField).FillAsync(password);
        public async Task ClickLogin() => await _page.Locator(_loginButton).ClickAsync();

        public async Task<bool> IsOnLoginPage() => _page.Url.Contains("saucedemo");
    }
}