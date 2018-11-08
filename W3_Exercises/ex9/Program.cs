using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.Write("Enter the first number:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number:");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the fourth number:");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The average of {num1},{num2},{num3},{num4} is: {(num1 + num2 + num3 + num4)/4} ");
        }
    }
}
