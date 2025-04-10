using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35._1
{
    class NonFictionBook : Book
    {
        private string subject;
        public string Subject { get => subject; set => subject = value; }
        public NonFictionBook(string title, string author, double price, int year, string subject) : base(title, author, price, year)
        {
            Subject = subject;
        }
        public override void Print()
        {
            Console.WriteLine($"Нехудожественная книга: {Title}\tАвтор: {Author}\tТема:{Subject}\t цена: {Price}\tГод издания: {Year}");
        }
        public static NonFictionBook Create()
        {
            Console.Clear();
            Console.Write("Введите название: ");
            string title = Console.ReadLine();
            Console.Write("Введите автора: ");
            string author = Console.ReadLine();
            Console.Write("Введите тему/предмет, на который книга ориентриуется: ");
            string subject = Console.ReadLine();
            Console.Write("Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            return new NonFictionBook(title, author, price, year, subject);
        }
    }
}
