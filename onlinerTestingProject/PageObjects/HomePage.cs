﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTestingProject.PageObjects
{
    public class HomePage
    {
        private By SignInButton = By.XPath("//*[@id='userbar']//div[text()='Вход']");

        private By ProfileLink = By.XPath("//a[contains(@class,'profile__preview')]");

        private By SearchField = By.XPath("//*[@class='fast-search__input']");

        private By TechSection = By.XPath("//h2//*[text()='Технологии']");

        private By LastNews = By.XPath("//div[contains(@class,'main-page-news')][./header//*[text()='Технологии']]/div//li[last()]");



        public void ClickSignInButton()
        {
            WebDriverFactory.Driver.FindElement(SignInButton).Click();
        }

        public bool IsProfileLinkDisplayed()
        {
            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementIsVisible(ProfileLink));
            return WebDriverFactory.Driver.FindElement(ProfileLink).Displayed;
        }

        public void SearchItem(string item)
        {
            WebDriverFactory.Driver.FindElement(SearchField).SendKeys(item);
        }

        public void ScrollToTech()
        {
            Actions builder = new Actions(WebDriverFactory.Driver);
            builder.MoveToElement(WebDriverFactory.Driver.FindElement(TechSection)).Build().Perform();
        }

        public void ClickLastNews()
        {
            WebDriverFactory.Driver.FindElement(LastNews).Click();
        }
    }
}
