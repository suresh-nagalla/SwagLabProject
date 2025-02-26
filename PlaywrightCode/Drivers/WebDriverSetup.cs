using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        protected IPlaywright Playwright;
        protected IBrowser Browser;
        protected IPage Page;

        [SetUp]
        public async Task SetupAsync()
        {
            Playwright = await Playwright.CreateAsync();
            Browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await Browser.NewContextAsync();
            Page = await context.NewPageAsync();
            await Page.GotoAsync("https://www.saucedemo.com/");
        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await Browser.CloseAsync();
            Playwright.Dispose();
        }
    }
}