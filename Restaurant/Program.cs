using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new instance of a menu item
            MenuItem chocolateCupcake = new MenuItem(true, "dessert", "light and, rich chocolatey flavor; buttercream frosting", 3.50, "Chocolate Cupcake");
            MenuItem chocolateChipCookie = new MenuItem(true, "dessert", "sweet and crisp", 1.75, "Chocolate Chip Cookie");
            MenuItem tiramisu = new MenuItem(true, "dessert", "rich espresso sponge cake", 4.50, "Tiramisu");

            // Create new instance of a menu
            Menu dessertMenu = new Menu(181210);

            // Add menu items to the Desset Menu
            dessertMenu.AddItem(chocolateCupcake);
            dessertMenu.AddItem(chocolateChipCookie);
            dessertMenu.AddItem(tiramisu);

            // Pre-method way of adding dessert item below
            /* dessertMenu.Items.Add(chocolateCupcake);
            dessertMenu.Items.Add(chocolateChipCookie); */

            // Print each item in the list
            dessertMenu.PrintMenu();

            // Pre-method way of printing each item in the dessert menu below
            /*for (int i = 0; i < dessertMenu.Items.Count; i++)
            {
                Console.WriteLine(dessertMenu.Items[i].MenuItemName);
            }

            Console.ReadLine();*/

        }
    }

    public class Menu
    {
        private int lastUpdated;
        private List<MenuItem> items = new List<MenuItem>();
        

        public int LastUpdated
        {
            get { return lastUpdated; }
            set { lastUpdated = value; }
        }

        public List<MenuItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        public Menu(int lastUpdated)
        {
            LastUpdated = lastUpdated;
        }

        public void AddItem(MenuItem menuItem)
        {
            items.Add(menuItem);
        }

        public void PrintMenu()
        {
            foreach (MenuItem item in items)
            {
                Console.WriteLine(item.MenuItemName);
            }

            Console.ReadLine();
        }
    }

    public class MenuItem
    {
        private bool menuItemIsNew;
        private string menuItemCategory;
        private string menuItemDescription;
        private double menuItemPrice;
        private string menuItemName;


        // PROPERTIES
        public bool MenuItemIsNew
        {
            get { return menuItemIsNew; }
            set { menuItemIsNew = value; }
        }


        public string MenuItemCategory
        {
            get { return menuItemCategory; }
            set { menuItemCategory = value; }
        }


        public string MenuItemDescription
        {
            get { return menuItemDescription; }
            set { menuItemDescription = value; }
        }


        public double MenuItemPrice
        {
            get { return menuItemPrice; }
            set { menuItemPrice = value; }
        }

        public string MenuItemName
        {
            get { return menuItemName; }
            set { menuItemName = value; }
        }

        // CONSTRUCTOR FUNCTIONS

        public MenuItem(
            bool menuItemIsNew,
            string menuItemCategory,
            string menuItemDescription,
            double menuItemPrice,
            string menuItemName)
        {
            MenuItemName = menuItemName; // Assigning function parameters to the properties
            MenuItemPrice = menuItemPrice;
            MenuItemDescription = menuItemDescription;
            MenuItemCategory = menuItemCategory;
            MenuItemIsNew = menuItemIsNew;
        }

    }
}
