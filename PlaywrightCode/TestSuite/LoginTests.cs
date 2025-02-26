using NUnit.Framework;
using SwagLabProject.PlaywrightCode.Actions;
using SwagLabProject.PlaywrightCode.Drivers;
using SwagLabProject.PlaywrightCode.Pages;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.TestSuite
{
    public class LoginTests : WebDriverSetup
    {
        [Test]
        public async Task Login_WithValidCredentials_ShouldBeSuccessful()
        {
            var loginPage = new LoginPage(Page);
            var loginActions = new LoginActions(loginPage);

            await loginActions.LoginAsync("standard_user", "secret_sauce");

            Assert.That((await Page.UrlAsync()).Contains("inventory"), "Login failed!");
        }
    }
}