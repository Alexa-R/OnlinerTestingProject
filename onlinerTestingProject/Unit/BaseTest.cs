using System.Configuration;
using NUnit.Framework;
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
                string url = ConfigurationManager.AppSettings["message"];
                WebDriverFactory.GoToUrl(url);
                //WebDriverFactory.GoToUrl("https://www.onliner.by/");
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