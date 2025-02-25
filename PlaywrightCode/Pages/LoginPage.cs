using Microsoft.Playwright;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;
        private readonly ILocator _usernameInput;
        private readonly ILocator _passwordInput;
        private readonly ILocator _loginButton;

        public LoginPage(IPage page)
        {
            _page = page;
            _usernameInput = page.Locator("#user-name");
            _passwordInput = page.Locator("#password");
            _loginButton = page.Locator("#login-button");
        }

        public async Task NavigateToLoginPage()
        {
            await _page.GotoAsync("https://www.saucedemo.com/");
        }

        public async Task EnterUsername(string username)
        {
            await _usernameInput.FillAsync(username);
        }

        public async Task EnterPassword(string password)
        {
            await _passwordInput.FillAsync(password);
        }

        public async Task ClickLoginButton()
        {
            await _loginButton.ClickAsync();
        }
    }
}