using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MenuItem
    {
        public string category { get; set; }
        public string description { get; set; }
        public double price { get; private set; }

        public void isNew()
        {
            //determine if the menu item is new and return string "NEW"
        }

        MenuItem(string Category, string Description, double Price)
        {
            Category = category;
            Description = description;
            Price = price;
        }
    }
}
