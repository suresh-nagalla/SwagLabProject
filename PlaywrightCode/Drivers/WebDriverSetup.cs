using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        protected IPlaywright Playwright;
        protected IBrowser Browser;
        protected IBrowserContext Context;
        protected IPage Page;

        [SetUp]
        public async Task SetupAsync()
        {
            Playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            Browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            Context = await Browser.NewContextAsync();
            Page = await Context.NewPageAsync();
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