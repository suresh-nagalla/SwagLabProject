using SwagLabProject.PlaywrightCode.Actions;
using SwagLabProject.PlaywrightCode.Drivers;
using SwagLabProject.PlaywrightCode.Pages;

namespace SwagLabProject.PlaywrightCode.TestSuite
{
    public class LoginTests : WebDriverSetup
    {
        [Test]
        public async Task Login_WithValidCredentials_ShouldBeSuccessful()
        {
            var loginActions = new LoginActions(page);
            await loginActions.Login("standard_user", "secret_sauce");

            var loginPage = new LoginPage(page);
            Assert.That(page.Url.Contains("inventory"), "Login failed!");
        }
    }
}