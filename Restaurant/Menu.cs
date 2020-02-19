using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        public List<MenuItem> items = new List<MenuItem>();
        public DateTime timeUpdated { get; set; }

    }
}
