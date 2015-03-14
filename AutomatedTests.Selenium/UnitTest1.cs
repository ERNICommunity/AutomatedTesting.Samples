using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace AutomatedTests.Selenium
{
    [TestFixture]
    public class UnitTest1
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
        public void TestMethod1()
        {


            _driver.Navigate().GoToUrl("http://www.google.co.uk");
            IWebElement query = _driver.FindElement(By.Name("q"));
            query.SendKeys("ERNI Consulting AG");
            query.Submit();
            Thread.Sleep(1000);
            Assert.That(_driver.PageSource.Contains("ERNI is an international consulting"));

        }


    }
}

