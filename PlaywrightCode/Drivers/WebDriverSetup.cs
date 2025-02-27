using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        protected IBrowser _browser;
        protected IBrowserContext _context;
        protected IPage _page;

        [SetUp]
        public async Task Setup()
        {
            var playwright = await Playwright.CreateAsync();
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
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