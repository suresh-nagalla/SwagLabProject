using NUnit.Framework;
using Microsoft.Playwright;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        protected IPlaywright _playwright;
        protected IBrowser _browser;
        protected IBrowserContext _context;
        protected IPage _page;

        [SetUp]
        public async Task Setup()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            _context = await _browser.NewContextAsync();
            _page = await _context.NewPageAsync();
            await _page.GotoAsync("https://www.saucedemo.com/");
        }

        [TearDown]
        public async Task TearDown()
        {
            await _browser.CloseAsync();
        }
    }
}