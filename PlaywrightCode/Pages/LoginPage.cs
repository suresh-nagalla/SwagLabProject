using Microsoft.Playwright;

namespace SwagLabProject.PlaywrightCode.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;

        public LoginPage(IPage page) => _page = page;

        public async Task EnterUsername(string username) => await _page.Locator("#user-name").FillAsync(username);
        public async Task EnterPassword(string password) => await _page.Locator("#password").FillAsync(password);
        public async Task ClickLogin() => await _page.Locator("#login-button").ClickAsync();

        public async Task<bool> IsOnLoginPage() => await _page.Url.ContainsAsync("saucedemo");
    }
}