using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvumeren_Masiv_Matrix_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows, col;
            Console.Write("Write the number of rows in the matrix: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write the number of columns in the matrix: ");
            col = Convert.ToInt32(Console.ReadLine());
            int[,] jaggedArr = new int[rows, col];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Enter element ({i},{j}): ");
                    jaggedArr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The matrix is: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(" " + jaggedArr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
