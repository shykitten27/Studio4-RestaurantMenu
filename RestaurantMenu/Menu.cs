using System;
using System.Collections.Generic;
using System.Linq;
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

        private void UpdateMenu(string action, string name, string description, double price, List<string> category, bool isNew)
        {
            //check for valid actions
            if (!action.Equals("add") || !action.Equals("remove")) {
                Console.WriteLine("Invalid action - must be add or remove.");
                return;
            }
            else if (action.Equals("add")) //ADD 
            {
                if (MenuItems.Contains(name)) //check for existence 
                { 
                    Console.WriteLine("Menu item already exists."); 
                    return;
                }
                else //does not already exist add new MenuItem.
                {
                    MenuItem newItem = new MenuItem(name, description, price, category, true);
                    Console.WriteLine(name + " added to menu.");
                    return;
                }
            }
            else if (action.Equals("remove")) //REMOVE 
            {
                if (MenuItems.Contains(name)) //check for existence before removing
                {
                    Console.WriteLine("Menu item " + name + " removed.");
                    return;
                }
                else //does not exist, display warning.
                {
                    Console.WriteLine("Menu item " + name + " does not exist.");
                    return;
                }
            }
        }

        public void DisplayNewMenuItems()
        {
            foreach (List<MenuItem> in MenuItems)
            {
                if (MenuItem.isNew)
                {
                    Console.WriteLine(MenuItems);
                }
                continue;
            }
        }
    }
}