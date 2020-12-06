using NUnit.Framework;
using OnlinerTestingProject.PageObjects;

namespace OnlinerTestingProject.TestCases
{
    public class BuyItem : BaseTest
    {
        [Test]
        public void Test()
        {
            Pages.HomePage.SearchItem("Ноутбук Apple MacBook Air 13 2020 MWTJ2");
            Pages.SearchResultPage.ClickItem();
            Pages.ProductPage.ClickAddToCartButton();
            Pages.ProductPage.OpenCartPage();

            Assert.AreEqual("Оформить заказ", Pages.CartPage.GetCheckoutButtonText());
        }
    }
}
