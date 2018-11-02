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
            int[,] arrA, arrB, buffer;
            int rowsA, rowsB, colA, colB;
            Console.Write("RowsA:");
            rowsA = Convert.ToInt32(Console.ReadLine());
            Console.Write("ColA:");
            colA = Convert.ToInt32(Console.ReadLine());
            arrA = new int[rowsA, colA];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    Console.Write($"Enter element [{i},{j}]");
                    arrA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix A is:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    Console.Write(" " + arrA[i,j] + " ");
                    
                }
                Console.WriteLine();
            }

            Console.Write("RowsB:");
            rowsB = Convert.ToInt32(Console.ReadLine());
            Console.Write("ColB:");
            colB = Convert.ToInt32(Console.ReadLine());
            arrB = new int[rowsB, colB];
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    Console.Write($"Enter element [{i},{j}]");
                    arrB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix B is:");
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    Console.Write(" " + arrB[i,j] + " ");
                }
                Console.WriteLine();
            }
            buffer = new int[Math.Max(rowsA, rowsB), Math.Max(colA, colB)];
            Console.WriteLine("Matrix A Transposed is:");
            for (int i = 0; i < colA; i++)
            {
                for (int j = 0; j < rowsA; j++)
                {
                    Console.Write(" " + arrA[j, i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix B Transposed is:");
            for (int i = 0; i < colB; i++)
            {
                for (int j = 0; j < rowsB; j++)
                {
                    Console.Write(" " + arrB[j, i] + " ");
                }
                Console.WriteLine();
            }

        }
    }

}