using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Starters cost 4.40 each");
            Console.WriteLine("Mains cost 7 each");

            var menuList = new MenuList();

            var orderMenu = menuList.orderMenu;
            orderMenu.Add(1, new Menu("Starter1", 0, 4.40));
            orderMenu.Add(2, new Menu("Starter2", 0, 4.40));
            orderMenu.Add(3, new Menu("Starter3", 0, 4.40));
            orderMenu.Add(4, new Menu("Main1", 0, 7));
            orderMenu.Add(5, new Menu("Main2", 0, 7));
            orderMenu.Add(6, new Menu("Main3", 0, 7));

            menuList.printMenu();

            while (true)
            {
                Console.WriteLine("Enter an item number to order, 0 to Checkout");
                int Option = int.Parse(Console.ReadLine());

                if (Option == 0)
                    break;

                if (orderMenu.ContainsKey(Option))
                    Console.WriteLine("You have Selected {0}", orderMenu[Option].Item);
                else
                {
                    Console.WriteLine("Error");
                    continue;
                }

                if (orderMenu[Option].Quantity > 0)
                    Console.WriteLine("You have ordered {0} of {1} already. Enter new qty to update, 0 to remove item from Order ", orderMenu[Option].Quantity, orderMenu[Option].Item);
                else
                    Console.WriteLine("Please Enter an Qty");
                int Qty = int.Parse(Console.ReadLine());
                Menu order = orderMenu[Option];
                order.Quantity = Qty;

                Console.WriteLine("Your Current Order");
                menuList.printCurrentOrder();
                Console.WriteLine("Your Order Value is " + menuList.calculateTotal());
            }

            Console.WriteLine("Your Order Value is {0}, press Enter to exit.", menuList.calculateTotal());

            Console.ReadLine();
        }
    }
}
