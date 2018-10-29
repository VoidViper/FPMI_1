using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Operation_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string operation;
            bool doContinue = false;

            do
            {
                Console.Write("num1:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("num2:");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("operation:");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        Console.WriteLine(num1 / num2);
                        break;
                }
                Console.WriteLine("Do you want to continue? [y/n]: ");
                if (Console.ReadLine() == "y")
                {
                    doContinue = true;
                }
                else doContinue = false;
            }
            while (doContinue == true);
        }
    }
}
