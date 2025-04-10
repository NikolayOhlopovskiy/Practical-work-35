using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35._2
{
    abstract class Dish
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Calories { get; set; }
        public int PreparationTime { get; set; }

        protected Dish(string name, decimal price, int calories, int preparationTime)
        {
            Name = name;
            Price = price;
            Calories = calories;
            PreparationTime = preparationTime;
        }

        public abstract void DisplayInfo();
    }
}
