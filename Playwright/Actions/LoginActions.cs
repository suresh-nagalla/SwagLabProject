using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using SwagLabProject.Playwright.Pages;

namespace SwagLabProject.Playwright.Actions
{
    public class LoginActions
    {
        private readonly LoginPage _loginPage;

        public LoginActions(IPage page) => _loginPage = new LoginPage(page);

        public async Task LoginAsync(string username, string password)
        {
            await _loginPage.EnterUsernameAsync(username);
            await _loginPage.EnterPasswordAsync(password);
            await _loginPage.ClickLoginAsync();
        }
    }
}
