using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Menu
    {
        public string Item { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Menu(string item, int quantity, double price)
        {
            Item = item;
            Quantity = quantity;
            Price = price;
        }
    }
}
