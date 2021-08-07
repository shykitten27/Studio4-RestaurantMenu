using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<string> Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(string name, string description, double price, List<string> category, bool isNew)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            IsNew = IsNew;
        }

        public void DisplayNewMenuItem(MenuItem item) //new
        {
            if (IsNew) //true
            {
                Console.WriteLine(item.ToString()); //prints the custom override 
                return;
            }
        }

/*        public Boolean CompareMenuItems(MenuItem item1, MenuItem item2)
        {
            //do something here override Equals method perhaps?
        }*/

/*       public override boolean Equals(object toBeCompared)
        {

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            MenuItem m = toBeCompared as MenuItem;
            return m.MenuItems == MenuItems;
        }*/

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description, Price, Category, IsNew);
        }

        public override string ToString()
        {
            return ("Name: " + Name + ", Description: " + Description + "Price: " + Price + "Category: " + Category + "IsNew: " + IsNew);
        }
    }
}
