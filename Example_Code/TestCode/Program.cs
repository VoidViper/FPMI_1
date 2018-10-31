using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[10, 10];
            int[,] arr2 = new int[10, 10];
            int[,] arr3 = new int[10, 10];
            Console.WriteLine("Substraction of two matrix");
            Console.WriteLine("----------------------------------------");
            Console.Write("Input the size of the square matrix: ");
            var n = int.Parse(Console.ReadLine());
            // First matrix
            Console.WriteLine("Input elements in the first matrix : ");
            for (int i = 0; i < n; i++)
            {
                for (int index = 0; index < n; index++)
                {
                    Console.Write($"element: [{i}],[{index}] ", i, index);
                    arr1[i, index] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Input elements in the second matrix : ");
            // Second Matrix
            for (int i = 0; i < n; i++)
            {
                for (int index = 0; index < n; index++)
                {
                    Console.Write($"element: [{i}],[{index}] ", i, index);
                    arr2[i, index] = int.Parse(Console.ReadLine());
                }
            }
            // The First Matrix
            Console.WriteLine("The First Matrix is :");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("");
                for (int index = 0; index < n; index++)
                    Console.Write("{0} ", arr1[i, index]);
                Console.WriteLine();
            }
            // Second Matrix
            Console.WriteLine("The Second Matrix is :");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("");
                for (int index = 0; index < n; index++)
                    Console.Write("{0} ", arr2[i, index]);
                Console.WriteLine();
            }
            // The Subtraction :
            for (int i = 0; i < n; i++)
            {
                for (int index = 0; index < n; index++)
                {
                    arr3[i, index] = arr1[i, index] - arr2[i, index];
                }       
            }
            Console.WriteLine("The Substraction: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("");
                for (int index = 0; index < n; index++)
                    Console.Write("{0} ", arr3[i, index]);
                Console.WriteLine();
            }
        }
    }

}