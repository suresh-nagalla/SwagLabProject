using NUnit.Framework;
using SwagLabProject.PlaywrightCode.Actions;
using SwagLabProject.PlaywrightCode.Drivers;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.TestSuite
{
    public class LoginTests : WebDriverSetup
    {
        [Test]
        public async Task Login_WithValidCredentials_ShouldBeSuccessful()
        {
            var loginActions = new LoginActions(_page);
            await loginActions.LoginAsync("standard_user", "secret_sauce");

            var loginPage = new LoginPage(_page);
            Assert.That(_page.Url.Contains("inventory"), "Login failed!");
        }
    }
}