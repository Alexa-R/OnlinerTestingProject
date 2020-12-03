using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace onlinerTestingProject.PageObjects
{
    public class LogInPage
    {
        private By MailField = By.XPath("(//*[@class='auth-form__field']//input)[1]");

        private By PasswordField = By.XPath("//*[@type = 'password']");

        private By LogInButton = By.XPath("//button[contains(@class,'button')]");



        public void EnterMail()
        {
            WebDriverFactory.Driver.FindElement(MailField).SendKeys("novaj49910@58as.com");
        }

        public void EnterPassword()
        {
            WebDriverFactory.Driver.FindElement(PasswordField).SendKeys("qwerty1234");
        }

        public void ClickLogInButton()
        {
            WebDriverFactory.Driver.FindElement(LogInButton).Click();
        }
    }
}
