﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTestingProject.PageObjects
{
    public class ProductPage
    {
        private By AddToCartButton = By.XPath("//div[@class='product-aside__box']/a[contains(@class,'item-button')]");
        private By Cart = By.XPath("//*[@id='userbar']//*[@title='Корзина']");

        public void ClickAddToCartButton()
        {
            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(AddToCartButton));

            WebDriverFactory.Driver.FindElement(AddToCartButton).Click();
        }

        public void OpenCartPage()
        {
            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(AddToCartButton));

            WebDriverFactory.Driver.FindElement(Cart).Click();
        }


    }
}
