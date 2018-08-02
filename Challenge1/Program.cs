using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem VeggieBurger = new MenuItem("Burger", "Veggie burger", "onions,tomatos,veggie-pattie,cucumbers", 5.99, 1);
            MenuItem VeggiePizza = new MenuItem("Pizza", "Veggie Pizza", "onions, tomatos , olives, cheese", 9.99, 2);
            MenuItem WhiteSaucePasta = new MenuItem("Pasta", "WhiteSaucePasta", "fullFatMilk,cheese,chicken,garlic-powder", 10.99, 3);
            MenuItem MangoLassi = new MenuItem("Lassi", "MangoLassi", "Mango-pulp, milk", 2.99, 4);

            MenuRepo menuRepo = new MenuRepo();
            menuRepo.addMenuToList(VeggieBurger);
            menuRepo.addMenuToList(VeggiePizza);
            menuRepo.addMenuToList(WhiteSaucePasta);
            menuRepo.addMenuToList(MangoLassi);

            List<MenuItem> menuItems = menuRepo.showMenuList();

            string Response = "null";
            while (Response != "4")
            {
                Console.WriteLine("Welcome to the kamodo cafe.\nPlease select from the following options below:\n1.)Add a menu item\n2.)Remove a menu item\n3.)List all menu items");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter menu name:");
                    string menuName = Console.ReadLine();

                    Console.WriteLine("Please enter menu description:");
                    string menuDescription = Console.ReadLine();

                    Console.WriteLine("Please enter menu ingredients:");
                    string menuIngredients = Console.ReadLine();

                    Console.WriteLine("Please enter menu price:");
                    double menuPrice = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter menu number:");
                    int menuNumber = int.Parse(Console.ReadLine());

                    MenuItem menuObject = new MenuItem(menuName, menuDescription, menuIngredients, menuPrice, menuNumber);
                    menuRepo.addMenuToList(menuObject);
                    Console.Clear();
                    Console.WriteLine("Here is the new menu list:");
                    foreach (MenuItem item in menuItems)
                    {
                        Console.WriteLine($"{item.MealNumber}" + " - " + $"{item.MealName}" + " , $" + $"{item.Price}");
                    }
                }
                else if (option == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Which menu item number would you like to remove?");
                    foreach (MenuItem item in menuItems)
                    {
                        Console.WriteLine($"{item.MealNumber}" + " - " + $"{item.MealName}" + " , $" + $"{item.Price}");
                    }
                    int removeItem = int.Parse(Console.ReadLine());

                    for (int i = 0; i < menuItems.Count; i++)
                    {
                        if (menuItems[i].MealNumber == removeItem)
                        {
                            menuRepo.removeMenuFromList(menuItems[i]);
                        }
                    }
                    Console.WriteLine("Here is the new menu list:");
                    foreach (MenuItem item in menuItems)
                    {
                        Console.WriteLine($"{item.MealNumber}" + " - " + $"{item.MealName}" + " , $" + $"{item.Price}");
                    }
                }
                else if (option == "3")
                {
                    foreach (MenuItem item in menuItems)
                    {
                        Console.WriteLine($"{item.MealNumber}" + " - " + $"{item.MealName}" + " , $" + $"{item.Price}");
                    }
                }
            }
        }
    }
}
