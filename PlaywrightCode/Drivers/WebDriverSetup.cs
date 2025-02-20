using Microsoft.Playwright;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        protected IPlaywright? playwright;
        protected IBrowser? browser;
        protected IPage? page;

        [SetUp]
        public async Task Setup()
        {
            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            page = await browser.NewPageAsync();
            await page.SetViewportSizeAsync(1920, 1080);
            await page.GotoAsync("https://www.saucedemo.com/");
        }

        [TearDown]
        public async Task TearDown()
        {
            if (page != null)
                await page.CloseAsync();
            if (browser != null)
                await browser.CloseAsync();
            if (playwright != null)
                playwright.Dispose();
        }
    }
}