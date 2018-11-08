using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number}{number}{number}");
            Console.WriteLine($"{number} {number}");
            Console.WriteLine($"{number} {number}");
            Console.WriteLine($"{number} {number}");
            Console.WriteLine($"{number}{number}{number}");
        }
    }
}
