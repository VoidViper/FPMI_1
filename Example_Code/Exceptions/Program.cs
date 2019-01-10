using System;
using System.IO;

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
                    Console.Write("First number: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Second number: ");
                    int b = int.Parse(Console.ReadLine());

                    if (b == 42) throw new DivideByFourtyTwoException();

                    int r = a / b;

                    Console.WriteLine($"Result: {r}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Error! Check the log.");
                    Logger.WriteToLog(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error! Check the log.");
                    Logger.WriteToLog(e.Message);
                }
                catch (DivideByFourtyTwoException e)
                {
                    Console.WriteLine("Error! Check the log.");
                    Logger.WriteToLog(e.Message);
                }
                Console.Write("Do you want to continue? [y/n]: ");
                if (Console.ReadLine() == "y") doContinue = true;
                else doContinue = false;

            }
            while (doContinue);
            
        }
    }
}
