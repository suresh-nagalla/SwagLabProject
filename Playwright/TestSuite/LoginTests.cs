using NUnit.Framework;
using SwagLabProject.Playwright.Actions;
using SwagLabProject.Playwright.Drivers;
using System.Threading.Tasks;

namespace SwagLabProject.Playwright.TestSuite
{
    public class LoginTests : WebDriverSetup
    {
        [Test]
        public async Task Login_WithValidCredentials_ShouldBeSuccessful()
        {
            var loginActions = new LoginActions(page);
            await loginActions.LoginAsync("standard_user", "secret_sauce");

            var loginPage = new SwagLabProject.Playwright.Pages.LoginPage(page);
            Assert.That((await page.UrlAsync()).Contains("inventory"), "Login failed!");
        }
    }
}
