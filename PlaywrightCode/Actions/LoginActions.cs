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

        public async Task LoginAsync(string username, string password)
        {
            await _loginPage.EnterUsernameAsync(username);
            await _loginPage.EnterPasswordAsync(password);
            await _loginPage.ClickLoginAsync();
        }
    }
}