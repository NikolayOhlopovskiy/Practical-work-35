using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35._1
{

    class Library
    {
        private List<FictionBook> fictionBooks = new List<FictionBook>();
        private List<NonFictionBook> nonFictionBooks = new List<NonFictionBook>();
        private List<Textbook> textBooks = new List<Textbook>();

        public void AddFictionBook(FictionBook fictionBook) => fictionBooks.Add(fictionBook);
        public void AddNonFictionBook(NonFictionBook nonFictionBook) => nonFictionBooks.Add(nonFictionBook);
        public void AddTextBook(Textbook textBook) => textBooks.Add(textBook);

        public void GetAllFictionBooks()
        {
            Console.Clear();
            Console.WriteLine("Художественные книги:");
            foreach (var f in fictionBooks) f.Print();
        }
        public void GetAllNonFictionBooks()
        {
            Console.Clear();
            Console.WriteLine("Нехудожественные книги:");
            foreach (var nf in nonFictionBooks) nf.Print();
        }
        public void GetAllTextBooks()
        {
            Console.Clear();
            Console.WriteLine("Грузовики:");
            foreach (var t in textBooks) t.Print();
        }
        public void GetAllBooks()
        {
            Console.Clear();
            var allBooks = new List<Book>();
            allBooks.AddRange(fictionBooks);
            allBooks.AddRange(nonFictionBooks);
            allBooks.AddRange(textBooks);
            Console.WriteLine("Все книги:");
            foreach (var b in allBooks)
            {
                b.Print();
            }
        }
    }

}
