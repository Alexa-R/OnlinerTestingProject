using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace onlinerTestingProject.Unit
{
    public class Tests
    {
        [TestFixture]
        public class BaseTest
        {

            [SetUp]
            public void SetUpTest()
            {
                WebDriverFactory.InitBrowser("Chrome");
                WebDriverFactory.GoToUrl("https://www.onliner.by/");
                WebDriverFactory.Driver.Manage().Window.Maximize();
            }

            [TearDown]
            public void TearDownTest()
            {
                WebDriverFactory.CloseAllDrivers();
            }
        }
    }
}