using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomatedTests.Selenium.Pages
{
    public class WelcomePage
    {
               
        private readonly RemoteWebDriver _driver;

         [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Sign in')]")]
        private IWebElement loginButton { get; set; }

        public WelcomePage(RemoteWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            _driver = driver;
            _driver.Navigate().GoToUrl("http://www.monocloud.ch/");
 
        }

        public void PressLogin()
        {
            loginButton.Click();
        }
    }
}