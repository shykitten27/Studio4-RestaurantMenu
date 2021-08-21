using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            //instantiate new MenuItem
            //is category a List of categories? If so I need to rething how to add the category to the List, should it be it's own class?
            MenuItem item1 = new MenuItem("Tiramisu", "Ladyfingers dipped in coffee, layered with marscapone filling and dusted with cocoa.", 6.00, "Dessert", false);
            MenuItem item2 = new MenuItem("Aviation", "Creme de violette blended with gin, lemon juice and a brandied cherry.", 8.00, "Cocktail", false);
            MenuItem item3 = new MenuItem("Shrimp Fra Diavolo", "Fiery spiced shrimp over a bed of angel hair pasta.", 18.00, "Entrée", true); //new item boolean set
            MenuItem item4 = new MenuItem("Zucchini Fritté", "Crispy, breaded, oven-fried zucchini served with aioli  dipping sauce.", 5.95, "Appetizer", true);

            //instantiate a new Menu
            Menu menu1 = new Menu(); //call constructor with no parms to create the actual menu object
            Console.WriteLine("adding menu items...");
            menu1.AddItemToMenu(item1); //adding items to newly instantiated menu1 <<<******
            menu1.AddItemToMenu(item2);
            menu1.AddItemToMenu(item3);
            menu1.AddItemToMenu(item4);

            Console.WriteLine("\nHere comes the menu...");
            menu1.PrintMenu(); //entire menu
            Console.WriteLine("\nHere comes one menu item...");
            menu1.PrintMenuItem(item2);
            Console.WriteLine("\nNow deleteing a menu item...");
            menu1.DeleteMenuItem(item2);
            Console.WriteLine("\nReprint the menu...");
            menu1.PrintMenu();
        }
    }
}
