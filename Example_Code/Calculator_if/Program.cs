using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_if
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            string operation;

            Console.Write("num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("num2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operation [+,-,*,/]: ");
            operation = Console.ReadLine();

            if (operation == "+")
            {
                num3 = num1 + num2;
                Console.Write($"The sum of num1 and num 2 is: {num3}", num3);
            }
            else if (operation == "-")
            {
                num3 = num1 - num2;
                Console.Write($"By subtracting the value of num2 from num1 you get: {num3}", num3);
            }
            else if (operation == "*")
            {
                num3 = num1 * num2;
                Console.Write($"By multiplying num1 and num2 you get : {num3}", num3);
            }
            else if (operation == "/")
            {
                num3 = num1 / num2;
                Console.Write($"Dividing num1 and num2 gives a result of: {num3}", num3);
            }
            Console.ReadLine();
        }
    }
}
