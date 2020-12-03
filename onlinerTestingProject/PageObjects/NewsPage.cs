using System;
using OpenQA.Selenium;

namespace onlinerTestingProject.PageObjects
{
    public class NewsPage
    {
        private By LikeCount = By.XPath("//*[@id= \"st-1\"]/div[1]/*[@class = \"st-count\"]");

        public string GetTextLikeCount() {
            return WebDriverFactory.Driver.FindElement(LikeCount).Text;
        }
    }
}
