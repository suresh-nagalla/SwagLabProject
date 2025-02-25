using NUnit.Framework;\nusing SwagLabProject.PlaywrightCode.Actions;\nusing SwagLabProject.PlaywrightCode.Drivers;\n\nnamespace SwagLabProject.PlaywrightCode.TestSuite\n{\n    public class LoginTests : WebDriverSetup\n    {\n        [Test]\n        public async Task Login_WithValidCredentials_ShouldBeSuccessful()\n        {\n            var loginActions = new LoginActions(_page);\n            await loginActions.Login("standard_user", "secret_sauce");\n\n            var loginPage = new SwagLabProject.PlaywrightCode.Pages.LoginPage(_page);\n            Assert.That(_page.Url.Contains("inventory"), "Login failed!");\n        }\n    }\n}