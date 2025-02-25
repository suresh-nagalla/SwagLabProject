using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightCode.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;

        public LoginPage(IPage page)
        {
            _page = page;
        }

        public async Task NavigateToAsync(string url)
        {
            await _page.GotoAsync(url);
        }

        public async Task EnterUsernameAsync(string username)
        {
            await _page.FillAsync("#username", username);
        }

        public async Task EnterPasswordAsync(string password)
        {
            await _page.FillAsync("#password", password);
        }

        public async Task ClickLoginButtonAsync()
        {
            await _page.ClickAsync("#login-button");
        }
    }
}