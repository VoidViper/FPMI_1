using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_ti_chlen
{
    class Program
    {
        static void IterativeFunction(int n)
        {
            Console.WriteLine("Iterative:");
            int[] a = new int[n];
            a[0] = 2;
            a[1] = 4;
            a[2] = 6;

            for (int i = 3; i < a.Length; i++)
            {
                a[i] = (3 * a[i - 3]) + (4 * a[i - 2]) - (7 * a[i - 1]);
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void RecursiveFunction(int n)
        {
            Console.WriteLine("Recursive:");
            int[] a = new int[n];
            a[1] = 2;
            a[2] = 4;
            a[3] = 6;
            
        }
        static void Main(string[] args)
        {
            //Ai = 3 * Ai-3 + 4 * Ai-2 - 7 * Ai-1
            //A1 = 2, A2 = 4, A3 = 6
            bool doContinue = true;
            do
            {
                Console.Write("Enter how many elements you would like to calculate (more than 3): ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Do you want to run the irrative funciton(1) or the recursive function(2)[e.g]:1");
                int p = int.Parse(Console.ReadLine());
                if (p == 1)
                {
                    if (n >= 3)
                    {
                        IterativeFunction(n);
                        doContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("The amount you have entered is not greater than or equal to 3. Please try again. ");
                    }
                }
                else if (p == 2)
                {
                    if (n >= 3)
                    {
                        RecursiveFunction(n);
                        doContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("The amount you have entered is not greater than or equal to 3. Please try again. ");
                    }
                }
                else Console.WriteLine("Invalid input. Try again.");
            }
            while (doContinue);
            
            
        }
    }
}
