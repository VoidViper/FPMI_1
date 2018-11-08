using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("Enter a number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a second number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"The fist number divided by the second number is : {num1/num2}");
        }
    }
}
