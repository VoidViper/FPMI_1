using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of the two numbers is : {num1+num2}");
        }
    }
}
