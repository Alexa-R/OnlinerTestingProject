using NUnit.Framework;
using OnlinerTestingProject.PageObjects;
using static OnlinerTestingProject.Unit.Tests;

namespace OnlinerTestingProject.TestCases
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
