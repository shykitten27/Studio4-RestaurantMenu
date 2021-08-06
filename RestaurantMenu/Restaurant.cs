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
            MenuItem item1 = new MenuItem("Tiramisu", "Ladyfingers dipped in coffee, layered with marscapone filling and dusted with cocoa.", 6.00, "Dessert", false);
            MenuItem item2 = new MenuItem("Aviation", "Creme de violette blended with gin, lemon juice and a brandied cherry.", 8.00, "Cocktail", false);
            MenuItem item3 = new MenuItem("Shrimp Fra Diavolo", "Fiery spiced shrimp over a bed of angel hair pasta.", 18.00, "Entrée", true); //new item boolean set
            MenuItem item4 = new MenuItem("Zucchini Fritté", "Crispy, breaded, oven-fried zucchini served with aioli  dipping sauce.", 5.95, "Appetizer", true);

            //instatian a new Menu
            Menu currentMenu = new Menu();

            Menu.PrintMenu();
            Menu.PrintMenu("Aviation");
            Menu.DeleteMenuItem("Aviation");
            Menu.PrintMenu();
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
