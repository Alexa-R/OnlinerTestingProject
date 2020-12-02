using NUnit.Framework;
using System;
using System.Configuration;

namespace OnlinerTestingProject
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
                WebDriverFactory.GoToUrl(ConfigurationManager.AppSettings["URL"]);
                WebDriverFactory.Driver.Manage().Window.Maximize();
                //WebDriverFactory.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            }

            [TearDown]
            public void TearDownTest()
            {
                WebDriverFactory.CloseAllDrivers();
            }
        }
    }
}