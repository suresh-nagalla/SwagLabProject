using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class PlaywrightSetup
    {
        protected IPlaywright Playwright;
        protected IBrowser Browser;
        protected IBrowserContext Context;
        protected IPage Page;

        [OneTimeSetUp]
        public async Task InitializePlaywright()
        {
            Playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            Browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            Context = await Browser.NewContextAsync();
            Page = await Context.NewPageAsync();
        }

        [OneTimeTearDown]
        public async Task CleanupPlaywright()
        {
            await Context?.CloseAsync();
            await Browser?.CloseAsync();
            Playwright?.Dispose();
        }
    }
}