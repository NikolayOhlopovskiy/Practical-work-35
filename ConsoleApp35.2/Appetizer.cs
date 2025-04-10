using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35._2
{
    class Appetizer : Dish
    {
        public int ServingSize { get; set; } // Размер порции в граммах

        public Appetizer(string name, decimal price, int calories, int preparationTime, int servingSize)
            : base(name, price, calories, preparationTime)
        {
            ServingSize = servingSize;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Закуска: {Name}, Цена: {Price:C}, Калории: {Calories}, Время приготовления: {PreparationTime} мин, Размер порции: {ServingSize} г");
        }
    }
}
