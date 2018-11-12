using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Example
{
    class Program
    {
        struct Book
        {
            public string Title, Author;
            public int ReleaseDate, Pages;
            public bool Read;
        }
        static string BookInspector(Book book)
        {
            return $"Author: {book.Author} \nTitle: {book.Title} \nRelease Date: {book.ReleaseDate} \nPages: {book.Pages} \nRead: {book.Read}";
        }
        
        static Book InsertBook()
        {
            Book book;
            Console.Write($"Insert the name of the book: ");
            book.Title = Console.ReadLine();
            Console.Write($"Insert the name of the author: ");
            book.Author = Console.ReadLine();
            Console.Write($"Insert the release date of the book: ");
            book.ReleaseDate = int.Parse(Console.ReadLine());
            Console.Write($"Insert the number of pages in the book: ");
            book.Pages = int.Parse(Console.ReadLine());
            Console.Write($"Have you read the book? [yes/no]: ");
            if (Console.ReadLine() == "yes")
            {
                book.Read = true;
            }
            else book.Read = false;
            return book;
        }

        static void Main(string[] args)
        {
            Book[] harryPotterBooks = new Book[3];

            for (int i = 0; i < 3; i++)
            {
                harryPotterBooks[i] = InsertBook();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(BookInspector(harryPotterBooks[i])); 
            }
        }
    }
}
