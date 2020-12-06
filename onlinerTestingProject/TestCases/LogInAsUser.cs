using NUnit.Framework;
using OnlinerTestingProject.PageObjects;
using OnlinerTestingProject;
using static OnlinerTestingProject.BaseTest;

namespace OnlinerTestingProject.TestCases
{
    public class LogInAsUser : BaseTest
    {
        [Test]
        public void LogInAsUserTest()
        {
            Pages.HomePage.ClickSignInButton();
            Pages.LogInPage.EnterMail("novaj49910@58as.com");
            Pages.LogInPage.EnterPassword("qwerty1234");
            Pages.LogInPage.ClickLogInButton();

            Assert.IsTrue(Pages.HomePage.IsProfileLinkDisplayed());
        }
    }
}
