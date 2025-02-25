using Microsoft.Playwright;
using NUnit.Framework;
using PlaywrightCode.Actions;
using PlaywrightCode.Drivers;
using PlaywrightCode.Pages;
using System.Threading.Tasks;

namespace PlaywrightCode.TestSuite
{
    [TestFixture]
    public class LoginTests
    {
        private WebDriverSetup _webDriverSetup;
        private IPage _page;
        private LoginActions _loginActions;

        [SetUp]
        public async Task Setup()
        {
            _webDriverSetup = new WebDriverSetup();
            _page = await _webDriverSetup.InitializeAsync();
            _loginActions = new LoginActions(_page);
        }

        [TearDown]
        public async Task Teardown()
        {
            await _webDriverSetup.CleanupAsync();
        }

        [Test]
        public async Task TestLogin()
        {
            var loginPage = new LoginPage(_page);
            await loginPage.NavigateToAsync("https://example.com/login");
            await _loginActions.LoginAsync("testuser", "testpassword");
            // Add assertions to verify successful login
        }
    }
}