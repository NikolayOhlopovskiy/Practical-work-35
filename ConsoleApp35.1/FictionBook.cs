using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35._1
{
    class FictionBook : Book
    {
        private string genre;
        public string Genre { get => genre; set => genre = value; }
        public FictionBook(string title, string author, double price, int year, string genre) : base(title, author, price, year)
        {
            Genre = genre;
        }
        public override void Print()
        {
            Console.WriteLine($"Художественная книга: {Title}\tАвтор: {Author}\tЖанр:{Genre}\t цена: {Price}\tГод издания: {Year}");
        }
        public static FictionBook Create()
        {
            Console.Clear();
            Console.Write("Введите название: ");
            string title = Console.ReadLine();
            Console.Write("Введите автора: ");
            string author = Console.ReadLine();
            Console.Write("Введите жанр: ");
            string genre = Console.ReadLine();
            Console.Write("Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            return new FictionBook(title, author, price, year, genre);
        }
    }
}
