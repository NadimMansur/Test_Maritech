using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    [TestFixture]
    public class CheckoutUnitTest
    {
        MenuList menuList = new MenuList();

        [Test]
        public void UnitTest1()
        {
            menuList.orderMenu.Add(1, new Menu("Starter1", 1, 4.40));
            menuList.orderMenu.Add(4, new Menu("Main1", 1, 7));
            double total = menuList.calculateTotal();
            Assert.AreEqual(11.4, menuList.calculateTotal());
        }

        [Test]
        public void UnitTest2()
        {
            menuList.orderMenu.Add(2, new Menu("Starter2", 1, 4.40));
            menuList.orderMenu.Add(5, new Menu("Main2", 2, 7));
            double total = menuList.calculateTotal();
            Assert.AreEqual(18.40, menuList.calculateTotal());
        }

        [Test]
        public void UnitTest3()
        {
            menuList.orderMenu.Add(3, new Menu("Starter2", 0, 4.40));
            menuList.orderMenu.Add(6, new Menu("Main2", 2, 7));
            double total = menuList.calculateTotal();
            Assert.AreEqual(14, menuList.calculateTotal());
        }

    }
}
