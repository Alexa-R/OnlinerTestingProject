using System;
using OnlinerTestingProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlinerTestingProject.PageObjects
{
    public class LogInPage
    {
        private By MailField = By.XPath("(//*[@class='auth-form__field']//input)[1]");

        private By PasswordField = By.XPath("//*[@type = 'password']");

        private By LogInButton = By.XPath("//button[contains(@class,'button')]");



        public void EnterMail(string mail)
        {
            WebDriverFactory.Driver.FindElement(MailField).SendKeys(mail);
        }

        public void EnterPassword(string password)
        {
            WebDriverFactory.Driver.FindElement(PasswordField).SendKeys(password);
        }

        public void ClickLogInButton()
        {
            WebDriverFactory.Driver.FindElement(LogInButton).Click();
        }
    }
}
