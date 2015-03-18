using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomatedTests.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomatedTests.Selenium
{

    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        public void Foo()
        {
            var driver = new FirefoxDriver();
           
            var browser = new Browser(driver);

            browser.WelcomePage.PressLogin();

            browser.LoginPage.EnterUsername("jazz");
            browser.LoginPage.EnterPassword("jazz");



            //var homepage =new WelcomePage(driver);
            //homepage.PressLogin();
            //var login = new LoginPage(driver);

            //login.EnterUsername("jazz.kang@erni.ch");
            //login.EnterPassword("CloudRocks@15");
            //login.Submit();

            driver.Quit();

        }

    }

    public class Browser
    {

        public Browser(RemoteWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            this.WelcomePage = new WelcomePage(driver);
            this.LoginPage = new LoginPage(driver);

        }

        public LoginPage LoginPage { get; set; }

        public WelcomePage WelcomePage { get; set; }
    }


}
