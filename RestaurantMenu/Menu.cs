using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        //Properties
        public List<MenuItem> MenuItems { get; set; }
        public DateTime LastUpdated { get; set; } //when the menu was last updated i.e. prices changed or items added

        //Constructor
        public Menu()
        {
            MenuItems = new List<MenuItem>(); //creating an empty list of MenuItem
            LastUpdated = DateTime.Now;
        }

        //Instance methods
        public List<MenuItem> AddItemToMenu(MenuItem newItem) //returns a List<MenuItem> passes a MenuItem parameter called newItem
        {
            //loop thru the list when the menuItems.Equals(newItem) write a message that newItem already exists
            for (int i = 0; i < MenuItems.Count; i++)
            {
                if (MenuItems.Equals(newItem)) //comparing the entire MenuItem - do we care about case for string values?
                {
                    Console.WriteLine(newItem + " already exists - duplicate item not added.");
                    return MenuItems;
                }
            }
            // if it gets to this point, the newItem was not found and can be added to list 
            MenuItems.Add(newItem); //adds the newItem to the MenuItems which is the name of the property of Menu.cs
            Console.WriteLine(newItem + " added to menu."); //message of successful add
            return MenuItems; //the List<MenuItem> named MenuItems is returned*/
        }

        public List<MenuItem> DeleteMenuItem(MenuItem deleteItem)
        {
            //loop thru the list when the menuItems.Equals(deleteItem) take that index and remove from the List of MenuItems
            for (int i=0; i<MenuItems.Count; i++)
            {
                if(MenuItems[i].Equals(deleteItem)) //comparing the entire MenuItem - do we care about case for string values?
                {
                        MenuItems.Remove(MenuItems[i]); //removes the newItem to the MenuItems which is the name of the property of Menu.cs
                        Console.WriteLine(deleteItem + " removed from menu.");
                        return MenuItems;
                    }
            }
            // if it gets to this point, the deleteItem was not found in list
            Console.WriteLine("Menu item " + deleteItem + " does not exist.");
            return MenuItems;
        }       

        public string DisplayLastUpdated()
        {
            return ("Menu was last updated on " + LastUpdated); //simply print the message with the value of the property DateTime 
        }

        public void PrintMenu() //print entire List of MenuItems using foreach loop
        {
            //foreach
            foreach(MenuItem item in MenuItems)
            {
                Console.WriteLine(item.ToString());
            }
            return;
        }

        public void PrintMenuItem(MenuItem menuItem) //search and print when found, otherwise print an error message
        {
            //loop thru the list when the menuItems.Equals(menuItem) take that index and remove a regular for loop
            for (int i = 0; i < MenuItems.Count; i++)
            {
                if (MenuItems.Equals(menuItem.Name))
                {
                    Console.WriteLine(menuItem.Name);
                    return;
                }
            }
            // if it gets to this point, the menuItem was not found in list
            Console.WriteLine("Menu item " + menuItem + " does not exist.");
            return;
        }

        public override bool Equals(object toBeCompared)
        {

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Menu m = toBeCompared as Menu;
            return m.LastUpdated == LastUpdated && m.MenuItems == MenuItems;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(MenuItems, LastUpdated);
        }

        public override string ToString()
        {
            return ("Menu was last updated on " + LastUpdated);
        }
    }
}