using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35._1
{
    abstract class Book
    {
        private string title;
        private string author;
        private int year;
        private double price;
        public double Price
        {
            get => price;
            set => price = value >= 0 ? value : throw new ArgumentException("цена не может быть отрицательной");
        }

        public int Year
        {
            get => year;
            set => year = value >= 1900 && value <= DateTime.Now.Year ? value : throw new ArgumentException("год указан неправильно");
        }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }

        public Book(string title, string author, double price, int year)
        {
            Title = title;
            Author = author;
            Price = price;
            Year = year;
        }
        public abstract void Print();
    }
}
