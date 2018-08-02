using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class MenuItem
    {
        // properties
        public string MealName { get; set; }
        public string Description { get; set; }
        public string ListOfIngredients { get; set; }
        public double Price { get; set; }
        public int MealNumber { get; set; }

        //constructor
        public MenuItem(string mealName, string description, string listOfIngredients, double price, int mealNumber)
        {
            MealName = mealName;
            Description = description;
            ListOfIngredients = listOfIngredients;
            Price = price;
            MealNumber = mealNumber;
        }
    }
}
