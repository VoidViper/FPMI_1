using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"{(num1+num2)*3}");
            }
            else Console.WriteLine("The two entered numbers are not equal");
        }
    }
}
