using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTestingProject.PageObjects
{
    public class NewsPage
    {
        private By LikeCount = By.XPath("//*[@id= \"st-1\"]/div[1]/*[@class = \"st-count\"]");

        public string GetTextLikeCount() {
            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementIsVisible(LikeCount));
            
            return WebDriverFactory.Driver.FindElement(LikeCount).Text;
        }
    }
}
