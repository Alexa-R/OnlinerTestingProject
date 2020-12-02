using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlinerTestingProject.PageObjects
{
    public class LogInPage
    {
        [FindsBy(How = How.XPath, Using = "(//*[@class='auth-form__field']//input)[1]")]
        private IWebElement MailField;

        [FindsBy(How = How.XPath, Using = "//*[@type = 'password']")]
        private IWebElement PasswordField;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'button')]")]
        private IWebElement LogInButton;


        public void EnterMail()
        {
            MailField.SendKeys("novaj49910@58as.com");
        }

        public void EnterPassword()
        {
            PasswordField.SendKeys("qwerty1234");
        }

        public void ClickLogInButton()
        {
            LogInButton.Click();
        }
    }
}
