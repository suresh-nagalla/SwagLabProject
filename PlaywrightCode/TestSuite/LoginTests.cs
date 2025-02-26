using NUnit.Framework;
using SwagLabProject.PlaywrightCode.Actions;
using SwagLabProject.PlaywrightCode.Drivers;

namespace SwagLabProject.PlaywrightCode.TestSuite
{
    public class LoginTests : WebDriverSetup
    {
        [Test]
        public async Task Login_WithValidCredentials_ShouldBeSuccessful()
        {
            var loginActions = new LoginActions(page);
            await loginActions.Login("standard_user", "secret_sauce");

            Assert.That(await page.Url.ContainsAsync("inventory"), "Login failed!");
        }
    }
}