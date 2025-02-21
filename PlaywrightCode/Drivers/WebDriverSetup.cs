using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        protected IPlaywright playwright;
        protected IBrowser browser;
        protected IPage page;
        protected IBrowserContext context;

        [SetUp]
        public async Task Setup()
        {
            playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            context = await browser.NewContextAsync();
            page = await context.NewPageAsync();
            await page.GotoAsync("https://www.saucedemo.com/");
        }

        [TearDown]
        public async Task TearDown()
        {
            await context?.CloseAsync();
            await browser?.CloseAsync();
            playwright?.Dispose();
        }
    }
}