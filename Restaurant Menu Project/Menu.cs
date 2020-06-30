using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Menu_Project
{
    class Menu
    {
        public Dictionary<string, MenuItems> theMenu = new Dictionary<string, MenuItems>();
        public DateTime lastUpdated = new DateTime();
    }
}
