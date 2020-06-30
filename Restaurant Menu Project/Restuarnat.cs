using System;

namespace RestaurantMenu
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            MenuItems item1 = new MenuItems(7.49, "Main", "Thinly sliced chicken glazed with teriyaki and grilled with onions, topped with Swiss cheese, lettuce, tomato and mayo.", false, new DateTime(2019, 1, 2));
            MenuItems item2 = new MenuItems(8.99, "Main", "Thinly sliced chicken, grilled with onions and topped with Swiss cheese, lettuce, tomato and mayo.", true, new DateTime(2018, 1, 2));

            Menu myMenu = new Menu();
            myMenu.AddItem("Teriyaki Chicken Sub", item1);
            myMenu.AddItem("Chicken Philly Sub", item2);

            Console.WriteLine(item1.ToString());
            Console.WriteLine(">>>><<<<");

            myMenu.PrintMenu();
            Console.WriteLine(">>>><<<<");


            myMenu.RemoveItem("Teriyaki Chicken Sub", item1);
            myMenu.PrintMenu();
            Console.WriteLine(">>>><<<<");

            myMenu.AddItem("Chicken Philly Sub", item2);

        }
    }
}

