using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlinerTestingProject.PageObjects
{
    public class HomePage
    {
       // private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='userbar']//div[contains(@class,'text')]")]
        private IWebElement SignInButton;

        public void ClickSignInButton()
        {
            SignInButton.Click();
        }

        //public HomePage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //    PageFactory.InitElements(driver, this);
        //}
    }
    
}
