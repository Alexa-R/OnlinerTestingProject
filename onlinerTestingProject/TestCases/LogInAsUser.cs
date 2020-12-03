using NUnit.Framework;
using onlinerTestingProject.PageObjects;
using static onlinerTestingProject.Unit.Tests;

namespace onlinerTestingProject.TestCases
{
    public class LogInAsUser : BaseTest
    {
        [Test]
        public void LogInAsUserTest()
        {
            Page.HomePage.ClickSignInButton();
            Page.LogInPage.EnterMail("novaj49910@58as.com");
            Page.LogInPage.EnterPassword("qwerty1234");
            Page.LogInPage.ClickLogInButton();

            Assert.IsTrue(Page.HomePage.IsProfileLinkDisplayed());
        }
    }
}
