using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                Console.WriteLine("\nВыберите нужное Вам действие:");
                Console.WriteLine("1. Добавить в список художественную книгу;");
                Console.WriteLine("2. Добавить в список Нехудожественную книгу;");
                Console.WriteLine("3. Добавить в список учебник;");
                Console.WriteLine("4. Вывести все художественные книги из списка;");
                Console.WriteLine("5. Вывести все нехудожественные книги из списка;");
                Console.WriteLine("6. Вывести все учебники из списка;");
                Console.WriteLine("7. Вывести все книги.");
                Console.WriteLine("8. Выход.");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        library.AddFictionBook(FictionBook.Create());
                        break;
                    case 2:
                        library.AddNonFictionBook(NonFictionBook.Create());
                        break;
                    case 3:
                        library.AddTextBook(Textbook.Create());
                        break;
                    case 4:
                        library.GetAllFictionBooks();
                        break;
                    case 5:
                        library.GetAllNonFictionBooks();
                        break;
                    case 6:
                        library.GetAllTextBooks();
                        break;
                    case 7:
                        library.GetAllBooks();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("!ОШИБКА!");
                        break;
                }
            }
            Console.Read();
        }
    }
}
