using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        private IPlaywright _playwright;
        private IBrowser _browser;

        public async Task<IPage> InitializeAsync()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            var context = await _browser.NewContextAsync();
            return await context.NewPageAsync();
        }

        public async Task CleanupAsync()
        {
            await _browser.CloseAsync();
            _playwright.Dispose();
        }
    }
}