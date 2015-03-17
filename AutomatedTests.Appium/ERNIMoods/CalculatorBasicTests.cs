﻿using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace AutomatedTests.Appium.Calculator
{
    [TestClass]
    public class ErniMoodTests
    {
        public AndroidDriver driver;
        private Process _process;

        [TestInitialize]
        public void BeforeAll()
        {

            StartAppiumServer();

            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("device", "Android");
            capabilities.SetCapability(CapabilityType.Platform, "Windows");
            capabilities.SetCapability("deviceName", "Nexus_5_API_21_x86");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "4.3");
    
            capabilities.SetCapability("app", @"C:\Users\jas\Downloads\erni-moods.apk");
            driver = new AndroidDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(360));            
        }

        private void StartAppiumServer()
        {
            _process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C C:\Users\jas\Desktop\Appium\node.exe C:\Users\jas\Desktop\Appium\node_modules\appium\bin\appium.js --address 127.0.0.1 --chromedriver-port 9516 --bootstrap-port 4735 --selendroid-port 8082 --no-reset --local-timezone --device-name Nexus_5_API_21_x86 --avd @Nexus_5_API_21_x86";
            _process.StartInfo = startInfo;
            _process.Start();
        }

        [TestCleanup]
        public void AfterAll()
        {
            driver.CloseApp();
            driver.Quit();
            _process.Close();
        }


        [TestMethod]
        public void TwoPlusFourEqualsSix()
        {
            var username = driver.FindElement(By.Name("Username"));
            Thread.Sleep(5000);

        }
    }
}
