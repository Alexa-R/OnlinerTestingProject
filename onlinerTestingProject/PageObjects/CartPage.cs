using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTestingProject.PageObjects
{
    public class CartPage
    {
        private By CheckoutButton = By.XPath("//*[contains(@class,'confirm')]//a");

        public string GetTextCheckoutButton() {
            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(CheckoutButton));

            return WebDriverFactory.Driver.FindElement(CheckoutButton).Text;
        }
    }
}
