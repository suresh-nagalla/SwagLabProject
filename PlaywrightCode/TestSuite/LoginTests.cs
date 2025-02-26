using NUnit.Framework;\nusing SwagLabProject.PlaywrightCode.Actions;\nusing SwagLabProject.PlaywrightCode.Drivers;\n\nnamespace SwagLabProject.PlaywrightCode.TestSuite\n{\n    public class LoginTests : WebDriverSetup\n    {\n        [Test]\n        public async Task Login_WithValidCredentials_ShouldBeSuccessful()\n        {\n            var loginActions = new LoginActions(page);\n            await loginActions.Login("standard_user", "secret_sauce");\n\n            Assert.That(await page.Url.ContainsAsync("inventory"), "Login failed!");\n        }\n    }\n}