using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, buffer = 0;
            Console.Write("Input the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            num2 = int.Parse(Console.ReadLine());

            buffer = num1;
            num1 = num2;
            num2 = buffer;

            Console.WriteLine($"The first number is: {num1}");
            Console.WriteLine($"The second number is: {num2}");
        }
    }
}
