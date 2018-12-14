using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class Program
    {
        static int factorial_Recursion(int number)
        { 
            if (number == 1)
                return  1;
            else
            {
                int resultPrevious = factorial_Recursion(number - 1);
                Console.WriteLine($"{number} * {resultPrevious}");
                return number * resultPrevious;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial_Recursion(n));
        }
    }
}
