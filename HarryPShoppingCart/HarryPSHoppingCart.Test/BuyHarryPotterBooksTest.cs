using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HarryPShoppingCart;

namespace HarryPSHoppingCart.Test
{
    [TestClass]
    public class BuyHarryPotterBooks
    {
        [TestMethod]
        public void 購買第1集_1本_0_off折扣_總金額100元()
        {
            //arrange
            PhenixCompany target = new PhenixCompany();
            int expected = 100;

            //act
            target.Buy(new Book { Title = "哈利波特", Story = 1, Count = 1, Amount = 100 });
            int actual = target.Settle();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 購買第1集_1本_第2集_1本_5_off折扣_總金額190元()
        {
            //arrange
            PhenixCompany target = new PhenixCompany();
            int expected = 190;

            //act
            target.Buy(new Book { Title = "哈利波特", Story = 1, Count = 1, Amount = 100 });
            target.Buy(new Book { Title = "哈利波特", Story = 2, Count = 1, Amount = 100 });
            int actual = target.Settle();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 購買第1集_1本_第2集_1本_第3集_1本_10_off折扣_總金額270元()
        {
            //arrange
            PhenixCompany target = new PhenixCompany();
            int expected = 270;

            //act
            target.Buy(new Book { Title = "哈利波特", Story = 1, Count = 1, Amount = 100 });
            target.Buy(new Book { Title = "哈利波特", Story = 2, Count = 1, Amount = 100 });
            target.Buy(new Book { Title = "哈利波特", Story = 3, Count = 1, Amount = 100 });
            int actual = target.Settle();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

    
}
