using NUnit.Framework;
using SwagLabProject.PlaywrightCode.Actions;
using SwagLabProject.PlaywrightCode.Drivers;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.TestSuite
{
    [TestFixture]
    public class LoginTests : PlaywrightSetup
    {
        private LoginActions _loginActions;

        [SetUp]
        public void Setup()
        {
            _loginActions = new LoginActions(Page);
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
            Assert.That(await errorElement.IsVisibleAsync());
        }
    }
}