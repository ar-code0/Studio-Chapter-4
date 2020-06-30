using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Menu_Project
{
    class MenuItems
    {
        public double Price { get; internal set; }
        public string Category { get; internal set; }
        public string Description { get; internal set; }
        public bool IsNew { get; internal set; }
        public DateTime updated { get; internal set; }

        public MenuItems(double price, string category, string description, bool isNew, DateTime updated)
        {
            Price = price;
            Category = category;
            Description = description;
            IsNew = isNew;
            this.updated = updated;
        }
    }
}
