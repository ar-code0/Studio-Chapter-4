using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public Dictionary<string, MenuItems> theMenu = new Dictionary<string, MenuItems>();
        public DateTime lastUpdated = new DateTime();

        public void AddItem(string name, MenuItems item)
        {
            bool isThere = false;
            foreach (KeyValuePair<string, MenuItems> entry in theMenu)
            {
                string mealName = entry.Key;
                MenuItems mealObj = entry.Value;

                if (mealObj.Equals(item) || theMenu.ContainsKey(name))
                {
                    isThere = true;
                    goto outOfLoop;
                }
            }
        outOfLoop:

            if (!isThere)
            {
                theMenu.Add(name, item);
            }
            else
            {
                throw new Exception("Item already in the menu");
            }
        }

        public void RemoveItem(string name, MenuItems item)
        {
            foreach (KeyValuePair<string, MenuItems> entry in theMenu)
            {
                string mealName = entry.Key;
                MenuItems mealObj = entry.Value;

                if (mealObj.Equals(item) && mealName == name)
                {
                    theMenu.Remove(mealName);
                    break;
                }
            }

        }
        public void LastUpdate()
        {
            DateTime date = new DateTime();
            foreach (KeyValuePair<string, MenuItems> entry in theMenu)
            {
                if (DateTime.Compare(entry.Value.updated, date) > 0)
                {
                    date = entry.Value.updated;
                }
            }

            lastUpdated = date;
        }

        public void PrintMenu()
        {
            if (theMenu.Count > 0)
            {
                foreach (KeyValuePair<string, MenuItems> entry in theMenu)
                {
                    Console.WriteLine("{0}\n{1}\n******", entry.Key, entry.Value.ToString());
                }
            }
            else
            {
                Console.WriteLine("No items on the menu");
            }
            LastUpdate();
            Console.WriteLine("Menu Updated " + lastUpdated);
        }
    }
}
