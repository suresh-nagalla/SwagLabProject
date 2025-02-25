using NUnit.Framework;
using Microsoft.Playwright;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        protected IBrowser browser;
        protected IBrowserContext context;
        protected IPage page;

        [SetUp]
        public async Task Setup()
        {
            using var playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            context = await browser.NewContextAsync();
            page = await context.NewPageAsync();
            await page.GotoAsync("https://www.saucedemo.com/");
        }

        [TearDown]
        public async Task TearDown()
        {
            await browser.CloseAsync();
        }
    }
}