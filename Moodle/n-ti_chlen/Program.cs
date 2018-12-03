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
            //proverka dali chisloto e >=3
            for (int i = 3; i < a.Length; i++)
            {
                a[i] = (3 * a[i - 3]) + (4 * a[i - 2]) - (7 * a[i - 1]);
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        /*static void RecursiveFunction(int n)
        {
            Console.WriteLine("Recursive:");
            int[] a = new int[n];
            a[1] = 2;
            a[2] = 4;
            a[3] = 6;
            
        }*/
        static void Main(string[] args)
        {
            //Ai = 3 * Ai-3 + 4 * Ai-2 - 7 * Ai-1
            //A1 = 2, A2 = 4, A3 = 6
            Console.Write("Enter how many elements you would like to show:");
            int n = int.Parse(Console.ReadLine());
            IterativeFunction(n);
            
        }
    }
}
