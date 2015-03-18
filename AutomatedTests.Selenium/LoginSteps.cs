using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace AutomatedTests.Selenium
{
    [Binding]
    public class LoginSteps
    {
        private FirefoxDriver _driver;

        [Given(@"I am using a web broweer")]
        public void GivenIAmUsingAWebBroweer()
        {
            _driver = new FirefoxDriver();
        }

        [Given(@"I am on the myData login page")]
        public void GivenIAmOnTheMyDataLoginPage()
        {
            


            _driver.Navigate().GoToUrl("http://www.monocloud.ch/");
            Thread.Sleep(3000);
            //  IWebElement button = _driver.FindElementByPartialLinkText("Sign in");
            var button = _driver.FindElementByXPath("//*[contains(text(), 'Sign in')]");
                //  FindElement(By.PartialLinkText("Sign in"));

            button.Click();
            Thread.Sleep(2000);
        }


        [When(@"I enter the username ""(.*)"" and password ""(.*)""""")]
        public void WhenIEnterTheUsernameAndPassword(string p0, string p1)
        {
            string username = "jazz.kang@erni.ch";
            string password = "CloudRocks@15";
            IWebElement usernameElement = _driver.FindElement(By.Id("usernameInput"));
            usernameElement.SendKeys(username);

            IWebElement passwordElement = _driver.FindElement(By.Id("passwordInput"));
            passwordElement.SendKeys(password);
            _driver.FindElement(By.Id("loginFormloginButton")).Click();

        
        
        }



        [When(@"I enter the username """"(.*)""""")]
        public void WhenIEnterTheUsername(string p0)
        {

        }

        [Then(@"I will be logged in")]
        public void ThenIWillBeLoggedIn()
        {
            
        }
    }
}