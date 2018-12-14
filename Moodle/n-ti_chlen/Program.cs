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
        static int RecursiveFunction(int n)
        {
            if (n <= 3) return 2 * n;
            return 3 * RecursiveFunction(n - 3) + 4 * RecursiveFunction(n - 2) - 7 * RecursiveFunction(n - 1);           
        }
        static void Main(string[] args)
        {
            //Ai = 3 * Ai-3 + 4 * Ai-2 - 7 * Ai-1
            //A1 = 2, A2 = 4, A3 = 6
            Console.WriteLine("This program find the n-th element with the formula An = 3 * An-3 + 4 * An-2 - 7 * An-1");
            Console.Write("Which element would you like to calculate ?: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Do you want to run the irrative funciton(1) or the recursive function(2)[e.g 1]: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                if (n >= 3)
                {
                    IterativeFunction(n);
                }
                else
                {
                    Console.WriteLine("The amount you have entered is not greater than or equal to 3. Please try again. ");
                }
            }
            else if (input == 2)
            {
                Console.WriteLine(RecursiveFunction(n));
            }
            else Console.WriteLine("Invalid input.");
        }
    }
}
