using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using SwagLabProject.PlaywrightCode.Pages;

namespace SwagLabProject.PlaywrightCode.Actions
{
    public class LoginActions
    {
        private readonly IPage _page;

        public LoginActions(IPage page) => _page = page;

        public async Task Login(string username, string password)
        {
            await _page.Locator("#user-name").FillAsync(username);
            await _page.Locator("#password").FillAsync(password);
            await _page.Locator("#login-button").ClickAsync();
        }
    }
}