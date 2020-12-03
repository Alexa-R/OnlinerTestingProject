using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace onlinerTestingProject.PageObjects
{
    public class ProductPage
    {
        private By AddToCartButton = By.XPath("(//*[@class = 'product-main']//*[contains(@data-href, 'cart')])[1]");

        public void ClickAddToCartButton()
        {
            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(AddToCartButton));

            WebDriverFactory.Driver.FindElement(AddToCartButton).Click();
        }
    }
}
