using System;
using NUnit.Framework;
using OnlinerTestingProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;

namespace OnlinerTestingProject.TestCases
{
    public class CountLikesOnNews
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.onliner.by/";
            
            //var homePage = new HomePage();
            PageInit.HomePage.ClickSignInButton();
            //homePage.ClickSignInButton();
            driver.Close();

        }
    }
}
