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
    }
}
