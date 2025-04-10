using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35._2
{
    class Restaurant
    {
        private List<Appetizer> appetizers = new List<Appetizer>();
        private List<MainCourse> mainCourses = new List<MainCourse>();
        private List<Dessert> desserts = new List<Dessert>();

        public void AddAppetizer(Appetizer appetizer)
        {
            appetizers.Add(appetizer);
        }

        public void AddMainCourse(MainCourse mainCourse)
        {
            mainCourses.Add(mainCourse);
        }

        public void AddDessert(Dessert dessert)
        {
            desserts.Add(dessert);
        }

        public void DisplayAllDishes()
        {
            Console.WriteLine("\n--- Закуски ---");
            foreach (var appetizer in appetizers)
            {
                appetizer.DisplayInfo();
            }

            Console.WriteLine("\n--- Основные блюда ---");
            foreach (var mainCourse in mainCourses)
            {
                mainCourse.DisplayInfo();
            }

            Console.WriteLine("\n--- Десерты ---");
            foreach (var dessert in desserts)
            {
                dessert.DisplayInfo();
            }
        }
    }
}
