using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Book
    { 
        public string Title, Author;
        public int ReleaseDate, Pages;
        public bool Read;

        static public void HelloFromStatic()
        {
            Console.WriteLine("Hello Static");
        }

        public void HelloFromNonStatic()
        {
            Console.WriteLine("Hello non static");
        }

        public string Inspect()
        {
            PrivateInspector();
            return $"Author: {this.Author} \nTitle: {this.Title} \nRelease Date: {this.ReleaseDate} \nPages: {this.Pages} \nRead: {this.Read}";
        }
        public void InsertBook()
        {
            Console.Write($"Insert the name of the book: ");
            this.Title = Console.ReadLine();
            Console.Write($"Insert the name of the author: ");
            this.Author = Console.ReadLine();
            Console.Write($"Insert the release date of the book: ");
            this.ReleaseDate = int.Parse(Console.ReadLine());
            Console.Write($"Insert the number of pages in the book: ");
            this.Pages = int.Parse(Console.ReadLine());
            Console.Write($"Have you read the book? [yes/no]: ");
            if (Console.ReadLine() == "yes")
            {
                this.Read = true;
            }
            else this.Read = false;
        }
        private void PrivateInspector()
        {
            Console.WriteLine("Hello from the private inspector");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            //book1.InsertBook();
            //Console.WriteLine(book1.Inspect());
            book1.HelloFromNonStatic();
            Book.HelloFromStatic();
            
        }
    }
}
