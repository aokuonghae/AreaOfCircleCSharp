using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem newItem1 = new MenuItem(4.99, "Garlic linguine", "Dinner", true);
            MenuItem newItem2 = new MenuItem(6.99, "Really good steak", "Dinner", false);
            MenuItem newItem3 = new MenuItem(2.99, "Delicious wings", "Appetizer", true);
            MenuItem newItem4 = new MenuItem(5.99, "Banana Split", "Desert", true);

            DateTime updated = DateTime.Now;
            List<MenuItem> myItems = new List<MenuItem>();
            myItems.Add(newItem1);
            myItems.Add(newItem2);
            myItems.Add(newItem3);
            Menu myMenu = new Menu(updated, myItems);

            //myMenu.PrintMenu();
            myMenu.RemoveItem(newItem3);
            myMenu.PrintMenu();
            myMenu.AddItem(newItem4);
            myMenu.PrintMenu();

        }
    }
}
