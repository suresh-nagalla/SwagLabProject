using System;
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

        [SetUp]
        public async Task SetupAsync()
        {
            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await browser.NewContextAsync();
            page = await context.NewPageAsync();
            await page.GotoAsync("https://www.saucedemo.com/");
        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await browser.CloseAsync();
            playwright.Dispose();
        }
    }
}