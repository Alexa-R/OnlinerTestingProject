using NUnit.Framework;
using onlinerTestingProject.PageObjects;
using static onlinerTestingProject.Unit.Tests;

namespace onlinerTestingProject.TestCases
{
    public class CheckLikesOnNews : BaseTest
    {
        [Test]
        public void Test()
        {
            Page.HomePage.ScrollToTech();
            Page.HomePage.ClickLastNews();

            Assert.True(int.Parse(Page.NewsPage.GetTextLikeCount()) >= 0);
        }
    }
}
