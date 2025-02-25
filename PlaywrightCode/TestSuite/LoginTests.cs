using NUnit.Framework;
using SwagLabProject.PlaywrightCode.Actions;
using SwagLabProject.PlaywrightCode.Drivers;
using SwagLabProject.PlaywrightCode.Pages;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.TestSuite
{
    [TestFixture]
    public class LoginTests : WebDriverSetup
    {
        private LoginActions _loginActions;
        private LoginPage _loginPage;

        [SetUp]
        public async Task TestSetup()
        {
            await base.Setup();
            _loginPage = new LoginPage(Page);
            _loginActions = new LoginActions(_loginPage);
        }

        [Test]
        public async Task ValidLogin_ShouldSucceed()
        {
            await _loginActions.LoginToApplication("standard_user", "secret_sauce");
            Assert.That(Page.Url, Does.Contain("inventory.html"));
        }

        [Test]
        public async Task InvalidLogin_ShouldFail()
        {
            await _loginActions.LoginToApplication("invalid_user", "invalid_password");
            var errorElement = Page.Locator("[data-test='error']");
            Assert.That(await errorElement.IsVisibleAsync(), Is.True);
        }
    }
}