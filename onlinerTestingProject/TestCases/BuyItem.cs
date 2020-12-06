using NUnit.Framework;
using OnlinerTestingProject.PageObjects;

namespace OnlinerTestingProject.TestCases
{
    public class BuyItem : BaseTest
    {
        [Test]
        public void Test()
        {
            Pages.HomePage.SearchItem("MacBook");
            Pages.SearchResultPage.ClickItem();
            Pages.ProductPage.ClickAddToCartButton();
            Pages.ProductPage.ClickAddToCartButton();

            Assert.AreEqual("Оформить заказ", Pages.CartPage.GetTextCheckoutButton());
        }
    }
}
