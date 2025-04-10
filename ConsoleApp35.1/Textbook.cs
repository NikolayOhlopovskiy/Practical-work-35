using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35._1
{
    class Textbook : Book
    {
        private string gradeLevel;
        public string GradeLevel { get => gradeLevel; set => gradeLevel = value; }

        public Textbook(string title, string author, double price, int year, string gradeLevel) : base(title, author, price, year)
        {
            GradeLevel = gradeLevel;
        }
        public override void Print()
        {
            Console.WriteLine($"Учебник: {Title}\tАвтор: {Author}\tУровень обучения:{GradeLevel}\t цена: {Price}\tГод издания: {Year}");
        }
        public static Textbook Create()
        {
            Console.Clear();
            Console.Write("Введите название: ");
            string title = Console.ReadLine();
            Console.Write("Введите автора: ");
            string author = Console.ReadLine();
            Console.Write("Введите уровень обучения(класс, университет): ");
            string gradeLevel = Console.ReadLine();
            Console.Write("Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            return new Textbook(title, author, price, year, gradeLevel);
        }
    }
}
