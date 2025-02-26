using Microsoft.Playwright;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;

        public LoginPage(IPage page) => _page = page;

        public async Task EnterUsernameAsync(string username) => await _page.Locator("#user-name").FillAsync(username);
        public async Task EnterPasswordAsync(string password) => await _page.Locator("#password").FillAsync(password);
        public async Task ClickLoginAsync() => await _page.Locator("#login-button").ClickAsync();

        public async Task<bool> IsOnLoginPageAsync() => (await _page.Url).Contains("saucedemo");
    }
}