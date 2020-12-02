using System;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace OnlinerTestingProject.PageObjects
{
    public class PageInit
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(WebDriverFactory.Driver, page);

            return page;
        }


        public static HomePage HomePage => GetPage<HomePage>();

        public static LogInPage LogInPage => GetPage<LogInPage>();


    }
}
