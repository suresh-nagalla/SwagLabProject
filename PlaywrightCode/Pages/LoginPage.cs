using System.Threading.Tasks;
using Microsoft.Playwright;

namespace SwagLabProject.PlaywrightCode.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;
        private readonly string _usernameSelector = "#user-name";
        private readonly string _passwordSelector = "#password";
        private readonly string _loginButtonSelector = "#login-button";

        public LoginPage(IPage page) => _page = page;

        public async Task EnterUsernameAsync(string username) => await _page.FillAsync(_usernameSelector, username);
        public async Task EnterPasswordAsync(string password) => await _page.FillAsync(_passwordSelector, password);
        public async Task ClickLoginAsync() => await _page.ClickAsync(_loginButtonSelector);

        public async Task<bool> IsOnLoginPageAsync() => (await _page.Url).Contains("saucedemo");
    }
}
