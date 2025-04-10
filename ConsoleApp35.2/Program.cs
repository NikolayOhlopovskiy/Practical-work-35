using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание ресторана
            Restaurant restaurant = new Restaurant();

            // Добавление закусок
            restaurant.AddAppetizer(new Appetizer("Сырные палочки", 5.99m, 250, 10, 150));
            restaurant.AddAppetizer(new Appetizer("Креветки в кляре", 8.99m, 300, 15, 200));

            // Добавление основных блюд
            restaurant.AddMainCourse(new MainCourse("Стейк", 19.99m, 500, 25, 7));
            restaurant.AddMainCourse(new MainCourse("Паста Карбонара", 12.99m, 450, 20, 3));

            // Добавление десертов
            restaurant.AddDessert(new Dessert("Чизкейк", 6.99m, 350, 10, true));
            restaurant.AddDessert(new Dessert("Шоколадный торт", 7.99m, 400, 15, false));

            // Вывод всех блюд
            restaurant.DisplayAllDishes();


            Console.ReadKey();
        }
    }
}
