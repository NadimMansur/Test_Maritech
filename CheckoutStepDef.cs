using Checkout;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Checkout
{
    [Binding]
    
    public sealed class StepDef
    {
        MenuList menuList = new MenuList();

        [Test]
        [Given(@"I Order (.*) of ""(.*)"" from Starters menu")]
        public void GivenIOrderOfFromStartersMenu(int qty, string item)
        {
            menuList.orderMenu.Add(1, new Menu(item, qty, 4.40));
        } 

        [Test]
        [Given(@"I Order (.*) of ""(.*)""  from Mains menu")]
        public void GivenIOrderOfFromMainsMenu(int qty, string item)
        {
            menuList.orderMenu.Add(1, new Menu(item, qty, 7));
        }
        
        [Test]
        [When(@"I Checkout")]
        public void WhenICheckout()
        {
            double total = menuList.calculateTotal();
        }

        [Test]
        [Then(@"Total is (.*)")]
        public void ThenTotalIs(double total)
        {
            Assert.AreEqual(11.4, menuList.calculateTotal());
        }
    }
}
