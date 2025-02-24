using System.Threading.Tasks;
using NUnit.Framework;
using SwagLabProject.PlaywrightCode.Actions;
using SwagLabProject.PlaywrightCode.Drivers;

namespace SwagLabProject.PlaywrightCode.TestSuite
{
    [TestFixture]
    public class LoginTests : WebDriverSetup
    {
        private LoginActions _loginActions;

        [SetUp]
        public async Task TestSetupAsync()
        {
            _loginActions = new LoginActions(page);
        }

        [Test]
        public async Task TestValidLoginAsync()
        {
            await _loginActions.LoginAsync("standard_user", "secret_sauce");
            Assert.IsTrue((await page.UrlAsync()).Contains("inventory"));
        }
    }
}
