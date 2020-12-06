using NUnit.Framework;
using OnlinerTestingProject.PageObjects;
using static OnlinerTestingProject.Unit.Tests;

namespace OnlinerTestingProject.TestCases
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
