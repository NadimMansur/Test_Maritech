using Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class MenuList
    {
        public Dictionary<int, Menu> orderMenu = new Dictionary<int, Menu>();

        public double calculateTotal()
        {
            double total = 0;
            foreach (KeyValuePair<int, Menu> item in orderMenu)
            {
                if (item.Value.Quantity > 0)
                    total += item.Value.Quantity * item.Value.Price;
            }
            return total;
        }

        public void printCurrentOrder()
        {
            foreach (KeyValuePair<int, Menu> item in orderMenu)
            {
                if (item.Value.Quantity > 0)
                    Console.WriteLine("{0} x {1}", item.Value.Quantity, item.Value.Item);
            }
        }

        public void printMenu()
        {
            foreach (KeyValuePair<int, Menu> item in orderMenu)
            {
                Console.WriteLine("{1} --- {0}", item.Value.Item, item.Key);
            }
        }
    }
}
