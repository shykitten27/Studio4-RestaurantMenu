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
            MenuItem item1 = new MenuItem("Tiramisu", "Ladyfingers dipped in coffee, layered with marscapone filling and dusted with cocoa.", 6.00, categoryList, false);
            MenuItem item2 = new MenuItem("Aviation", "Creme de violette blended with gin, lemon juice and a brandied cherry.", 8.00, categoryList, false);
            MenuItem item3 = new MenuItem("Shrimp Fra Diavolo", "Fiery spiced shrimp over a bed of angel hair pasta.", 18.00, categoryList, true); //new item boolean set

            //instatian a new Menu
            Menu currentMenu = new Menu();

            Menu.PrintMenu();
            Menu.PrintMenu("Aviation");
        }
    }
}
