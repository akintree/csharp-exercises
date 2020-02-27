using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MenuItem
    {
        public enum Category { Appetizer, MainCourse, Dessert }
        public string Name { get; set; }
        public MenuItem.Category MenuCategory { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime TimeUpdated { get; set; }
        public bool isNew {
            get { return TimeUpdated.Date >= DateTime.Now.Date.AddMonths(-3); } 
        }        
        public string LastUpdated()
        {
            return "Last updated: " + DateTime.Now.Subtract(TimeUpdated) + ".";
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != GetType())
            {
                return false;
            }

            MenuItem NameObject = obj as MenuItem;
            return Name == NameObject.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            string New = "";
            if (isNew)
            {
                New = " - New!";
            }
            return Name + "\n" + Description + ": " + Price.ToString() + "\n" + "Last updated: " + TimeUpdated.ToShortDateString() + New;
        }
    }
}
