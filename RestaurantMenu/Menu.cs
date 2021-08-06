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

        private List<MenuItem> AddItemToMenu(MenuItem newItem)
        {
            {
                MenuItems.Add(newItem);
                Console.WriteLine(newItem + " added to menu.");
                return MenuItems;
            }

        }

        private void DeleteMenuItem(MenuItem deletedItem)
        {
/*            if (MenuItems.Contains(name)) //check for existence before removing
            {
                Console.WriteLine("Menu item " + name + " removed.");
                return;
            }
            else //does not exist, display warning.*/
            {
                //loop thru the list, when the menuItems.Equals(newItem) take that index and remove a reggular for loop
                Console.WriteLine("Menu item " + deletedItem + " does not exist.");
                return;
            }
        }
        



        public string DisplayLastUpdated()
        {
            return ("Menu was last updated on " + LastUpdated);
        }


        public void PrintMenu(MenuItem menuItem) //print entire menu two different methods
        {
/*            if (menuItem.Equals(""))
            {*/
                foreach(MenuItem item in MenuItems)
                {
                    Console.WriteLine(item);
                }
                return;
 /*           }
            else
            {
                if(MenuItems.Contains(MenuItem))
                {
                    Console.WriteLine(MenuItem);
                    return;
                }
                else //item passed does not exist
                {
                    Console.WriteLine(menuItem + " does not exist");
                }*/
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}