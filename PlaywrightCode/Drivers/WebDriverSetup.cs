using Microsoft.Playwright;
using NUnit.Framework;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        protected IPlaywright Playwright;
        protected IBrowser Browser;
        protected IPage Page;
        protected IBrowserContext Context;

        [SetUp]
        public async Task Setup()
        {
            Playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            Browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            Context = await Browser.NewContextAsync();
            Page = await Context.NewPageAsync();
            await Page.GotoAsync("https://www.saucedemo.com/");
        }

        [TearDown]
        public async Task TearDown()
        {
            await Context.CloseAsync();
            await Browser.CloseAsync();
        }
    }
}