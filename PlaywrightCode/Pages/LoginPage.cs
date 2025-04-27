using Microsoft.Playwright;

namespace SwagLabProject.PlaywrightCode.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;
        private readonly ILocator _usernameField;
        private readonly ILocator _passwordField;
        private readonly ILocator _loginButton;

        public LoginPage(IPage page)
        {
            _page = page;
            _usernameField = _page.Locator("#user-name");
            _passwordField = _page.Locator("#password");
            _loginButton = _page.Locator("#login-button");
        }

        public async Task EnterUsername(string username) => await _usernameField.FillAsync(username);
        public async Task EnterPassword(string password) => await _passwordField.FillAsync(password);
        public async Task ClickLogin() => await _loginButton.ClickAsync();

        public bool IsOnLoginPage() => _page.Url.Contains("saucedemo");
    }
}