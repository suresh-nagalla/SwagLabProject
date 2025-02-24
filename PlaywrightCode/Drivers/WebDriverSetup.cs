using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        protected IPage Page;
        private IPlaywright _playwright;
        private IBrowser _browser;

        [SetUp]
        public async Task SetupAsync()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await _browser.NewContextAsync();
            Page = await context.NewPageAsync();
            await Page.GotoAsync("https://www.saucedemo.com/");
        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await _browser.CloseAsync();
            _playwright.Dispose();
        }
    }
}
