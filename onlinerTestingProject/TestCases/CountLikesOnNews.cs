using NUnit.Framework;
using OnlinerTestingProject.PageObjects;
using OnlinerTestingProject;
using static OnlinerTestingProject.BaseTest;

namespace OnlinerTestingProject.TestCases
{
    public class CheckLikesOnNews : BaseTest
    {
        [Test]
        public void Test()
        {
            Pages.HomePage.ScrollToTech();
            Pages.HomePage.ClickLastNews();

            Assert.True(int.Parse(Pages.NewsPage.GetTextLikeCount()) >= 0);
        }
    }
}
