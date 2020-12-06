using NUnit.Framework;
namespace OnlinerTestingProject
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
