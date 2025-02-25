using SwagLabProject.PlaywrightCode.Pages;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.Actions
{
    public class LoginActions
    {
        private readonly LoginPage _loginPage;

        public LoginActions(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }

        public async Task LoginToApplication(string username, string password)
        {
            await _loginPage.NavigateToLoginPage();
            await _loginPage.EnterUsername(username);
            await _loginPage.EnterPassword(password);
            await _loginPage.ClickLoginButton();
        }
    }
}