using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, absDiff;
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            absDiff = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                Console.WriteLine($"{2*absDiff}");
            }
            else Console.WriteLine("The first number is lower than the second one");
        }
    }
}
