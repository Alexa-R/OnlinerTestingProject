using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace onlinerTestingProject.PageObjects
{
    public class SearchResultPage
    {

        private By ProductsFrame = By.XPath("//iframe[@class = \"modal-iframe\"]");

        private By Item = By.XPath("(//a[@class = \"product__title-link\"])[2]");


        public void SwitchProductsFrame()
        {
            WebDriverFactory.Driver.SwitchTo().Frame(WebDriverFactory.Driver.FindElement(ProductsFrame));
        }

        public void ClickItem()
        {
            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(Item));

            WebDriverFactory.Driver.FindElement(Item).Click();
        }
    }
}