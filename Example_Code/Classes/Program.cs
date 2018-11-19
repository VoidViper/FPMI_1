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
        public virtual void InsertBook()
        {
            Console.Write($"Insert the name of the book: ");
            this.Title = Console.ReadLine();
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

    class HarryPotterBook : Book
    {
        public HarryPotterBook()
        {
            this.Author = "J. K. Rowling";
        }
        override public void InsertBook()
        {
            base.InsertBook();
            this.Author = "JK Rowling";
        }
    }

    class ClassWithNumber
    {
        public int number;
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* int a = 4;
             int b = a;

             Console.WriteLine(a);
             Console.WriteLine(b);

             a = 5;
             Console.WriteLine(a);
             Console.WriteLine(b);
             */
            //Book book1 = new HarryPotterBook();
            //book1.InsertBook();
            //Console.WriteLine(book1.Inspect());

            ClassWithNumber cw1 = new ClassWithNumber();
            cw1.number = 5;
            ClassWithNumber cw2 = cw1;

            Console.WriteLine(cw1.number);
            Console.WriteLine(cw2.number);

            cw2.number = 120;

            Console.WriteLine(cw1.number);
            Console.WriteLine(cw2.number);
        }
    }
}
