using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doContinue = false;
            do
            {
                try 
                {
                    double num1, num2;
                    Console.Write("Enter the first number: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = double.Parse(Console.ReadLine());
                    Console.Write("Enter an operation [+,-,/,sqrt,]");
                    string operation = Console.ReadLine();

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
                            if (num2.Equals(0)) throw new DoubleDevideByZeroException();
                            else Console.WriteLine(num1 / num2);
                            break;
                        case "sqrt":
                            Console.WriteLine("Square root of num1: " + Math.Sqrt(num1));
                            Console.WriteLine("Square root of num2: " + Math.Sqrt(num2));
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Refer to the calculator.log file for more information.");
                    Logger.WriteToLog(e.Message);
                    Logger.WriteToLog(e.StackTrace);
                }
                catch (DoubleDevideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Refer to the calculator.log file for more information.");
                    Logger.WriteToLog(e.Message);
                    Logger.WriteToLog(e.StackTrace);
                }

                Console.Write("Do you want to continue? [y/n]: ");
                if (Console.ReadLine() == "y") doContinue = true;
                else doContinue = false;

            }
            while (doContinue);
            
        }
    }
}
