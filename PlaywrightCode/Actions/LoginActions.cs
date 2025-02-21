using System.Threading.Tasks;
using Microsoft.Playwright;
using SwagLabProject.PlaywrightCode.Pages;

namespace SwagLabProject.PlaywrightCode.Actions
{
    public class LoginActions
    {
        private readonly LoginPage _loginPage;

        public LoginActions(IPage page) => _loginPage = new LoginPage(page);

        public async Task Login(string username, string password)
        {
            await _loginPage.EnterUsername(username);
            await _loginPage.EnterPassword(password);
            await _loginPage.ClickLogin();
        }
    }
}