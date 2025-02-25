using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightCode.Actions
{
    public class LoginActions
    {
        private readonly IPage _page;

        public LoginActions(IPage page)
        {
            _page = page;
        }

        public async Task LoginAsync(string username, string password)
        {
            await _page.FillAsync("#username", username);
            await _page.FillAsync("#password", password);
            await _page.ClickAsync("#login-button");
        }
    }
}