using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }
        public DateTime LastUpdated { get; set; } //when the menu was last updated i.e. prices changed or items added

        public Menu(List<MenuItem> menuItems)
        {
            MenuItems = menuItems;
            LastUpdated = DateTime.Now;
        }
    }

}