using System.Threading.Tasks;
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
            var loginActions = new LoginActions(Page);
            await loginActions.LoginAsync("standard_user", "secret_sauce");

            var loginPage = new SwagLabProject.PlaywrightCode.Pages.LoginPage(Page);
            Assert.That((await Page.UrlAsync()).Contains("inventory"), "Login failed!");
        }
    }
}