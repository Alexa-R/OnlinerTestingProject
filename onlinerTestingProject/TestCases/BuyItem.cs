using NUnit.Framework;
using OnlinerTestingProject.PageObjects;
using static OnlinerTestingProject.Unit.Tests;

namespace OnlinerTestingProject.TestCases
{
    public class BuyItem : BaseTest
    {
        [Test]
        public void Test()
        {
            Page.HomePage.Search("MacBook");
            Page.SearchResultPage.SwitchProductsFrame();
            Page.SearchResultPage.ClickItem();
            Page.ProductPage.ClickAddToCartButton();
            Page.ProductPage.ClickAddToCartButton();

            Assert.AreEqual("Оформить заказ", Page.CartPage.GetTextCheckoutButton());
        }
    }
}
