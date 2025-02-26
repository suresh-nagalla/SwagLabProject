using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        protected IBrowser Browser;
        protected IBrowserContext Context;
        protected IPage Page;

        [SetUp]
        public async Task Setup()
        {
            var playwright = await Playwright.CreateAsync();
            Browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            Context = await Browser.NewContextAsync();
            Page = await Context.NewPageAsync();
            await Page.GotoAsync("https://www.saucedemo.com/");
        }

        [TearDown]
        public async Task TearDown()
        {
            await Browser.CloseAsync();
        }
    }
}