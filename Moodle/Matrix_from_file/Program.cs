using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_from_file
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowSum = 0;
            var colSum = 0;
            Console.Write("Input the size of the square Matrix : ");
            int n = int.Parse(Console.ReadLine());
            string[,] matrixArr = new string[n, n];
            Console.WriteLine("Input elements in the Matrix : ");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"element - [{row},{col}] : ");
                    matrixArr[row, col] = Console.ReadLine();
                    if (matrixArr[row, col].Length == 0)
                    {
                        matrixArr[row, col] = "-1";
                    }
                }
            }

            TextWriter saveTheMatrix = new StreamWriter("matrix.txt");
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    saveTheMatrix.Write("row[{0}]", row);
                    saveTheMatrix.Write("\tcolumn[{0}]", column);
                    saveTheMatrix.Write("\t" + matrixArr[row, column]);
                    saveTheMatrix.WriteLine();
                }
            }
            saveTheMatrix.Close();

            Console.WriteLine("The Matrix is : ");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrixArr[row, col]}");
                    Console.Write(new string(' ', 4));
                }
                Console.WriteLine();
            }

            
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row % 2 != 0)
                    {
                        rowSum += Convert.ToInt32(matrixArr[row, col]);
                    }
                    if (col % 2 == 0)
                    {
                        colSum += Convert.ToInt32(matrixArr[row, col]);
                    }
                }
            }
            Console.WriteLine($"Sum of the elements of the elements in the even rows in the matrix : {rowSum}");
            Console.WriteLine($"Sum of the elements of the elements in the the odd columns in the matrix : {colSum}");
        }
    }
}
