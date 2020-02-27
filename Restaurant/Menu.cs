using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        public static List<MenuItem> Items = new List<MenuItem>();

        public static void AddToMenu(MenuItem MenuContent)
        {
            Items.Add(MenuContent);
        }

        public static void RemoveFromMenu(MenuItem ToDelete)
        {
            Items.Remove(ToDelete);
        }
        public static void PrintMenu()
        {
            foreach (object MenuItem in Items)
            {
                Console.WriteLine(MenuItem.ToString());
            }
            if (Items.Count < 1)
            {
                Console.WriteLine("Menu in progress.");
            } 
        }
        
    }
}
