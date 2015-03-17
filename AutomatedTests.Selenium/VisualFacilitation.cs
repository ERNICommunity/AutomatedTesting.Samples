using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomatedTests.Selenium
{
    [TestFixture]
    public class VisualFacilitation
    {
        private static FirefoxDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new FirefoxDriver();
        }

        [TearDown]
        public void TearDown()
        {

            _driver.Quit();

        }

        [Test]
        public void It_should_be_able_to_log_a_user_in()
        {
            _driver.Navigate().GoToUrl("");
            //open browser
            // go to url
            //login
            logInUser();
            Thread.Sleep(3000);
            Assert.That(_driver.PageSource.Contains("Welcome to the ERNI Visual Facilitation Application"));
        }

   


        [Test]
        public void It_should_be_able_to_navigate_to_basics()
        {
            logInUser();
            Thread.Sleep(3000);
           _driver.FindElementByPartialLinkText("BASICS").Click();
            Thread.Sleep(3000);
            Assert.True(_driver.PageSource.Contains("brick wall"));
        }




        private static void logInUser()
        {
            _driver.Navigate().GoToUrl("http://visualfacilitation.erni.ch");
            IWebElement username = _driver.FindElement(By.Id("username"));
            username.SendKeys("jazz");
            IWebElement password = _driver.FindElement(By.Id("password"));
            password.SendKeys("password");
            password.Submit();
        }
    }
}
