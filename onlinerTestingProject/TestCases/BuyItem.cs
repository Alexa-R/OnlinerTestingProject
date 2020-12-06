using NUnit.Framework;
using OnlinerTestingProject.PageObjects;
using OnlinerTestingProject.Unit;
using static OnlinerTestingProject.Unit.BaseTest;

namespace OnlinerTestingProject.TestCases
{
    public class BuyItem : BaseTest
    {
        [Test]
        public void Test()
        {
            Pages.HomePage.Search("MacBook");
            Pages.SearchResultPage.SwitchProductsFrame();
            Pages.SearchResultPage.ClickItem();
            Pages.ProductPage.ClickAddToCartButton();
            Pages.ProductPage.ClickAddToCartButton();

            Assert.AreEqual("Оформить заказ", Pages.CartPage.GetTextCheckoutButton());
        }
    }
}
