using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Shelf
    {
        public static List<Book> arrayOfBooks = new List<Book>();

        public static void Add(Book book)
        {
            arrayOfBooks.Add(book);
        }
    }
    class Book
    {
        public string Title {
            get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Wilbur's Wonderful Life";

            Shelf.Add(book1);

            foreach (var book in Shelf.arrayOfBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.Write("Please enter a book title: ");
            string input = Console.ReadLine();

            Book book2 = new Book();
            book2.Title = input;

            Shelf.Add(book2);

            foreach(var book in Shelf.arrayOfBooks)
            {
                Console.WriteLine(book.Title);
            }
            Console.Read();
        }
    }
}
