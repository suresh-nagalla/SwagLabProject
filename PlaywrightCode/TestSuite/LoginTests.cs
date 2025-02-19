using System.Threading.Tasks;\nusing NUnit.Framework;\nusing SwagLabProject.PlaywrightCode.Actions;\nusing SwagLabProject.PlaywrightCode.Drivers;\n\nnamespace SwagLabProject.PlaywrightCode.TestSuite\n{\n    public class LoginTests : WebDriverSetup\n    {\n        [Test]\n        public async Task Login_WithValidCredentials_ShouldBeSuccessful()\n        {\n            var loginActions = new LoginActions(page);\n            await loginActions.LoginAsync(\"standard_user\", \"secret_sauce\");\n\n            var loginPage = new SwagLabProject.PlaywrightCode.Pages.LoginPage(page);\n            Assert.That((await page.UrlAsync()).Contains(\"inventory\"), \"Login failed!\");\n        }\n    }\n}\n