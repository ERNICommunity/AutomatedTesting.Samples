using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomatedTests.Selenium.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "usernameInput")]
        private IWebElement _usernameField ;

        [FindsBy(How = How.Id, Using = "passwordInput")]
        private IWebElement _passwordField ; 
        
        [FindsBy(How = How.Id, Using = "loginFormloginButton")]
        private IWebElement _loginButton ;


        public LoginPage(RemoteWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void EnterUsername(string username)
        {
            _usernameField.SendKeys(username);          
        }

        public void EnterPassword(string password)
        {
            _passwordField.SendKeys(password);
        }

        public void Submit()
        {
            _loginButton.Click();
        }
    }
}