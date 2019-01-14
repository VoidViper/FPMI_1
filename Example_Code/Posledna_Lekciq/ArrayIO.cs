using System;
using System.IO;

namespace Posledna_Lekciq
{
    public class ArrayIO
    {
        public int[] matrix;
        public static void PrintArray(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            Console.WriteLine("The array in matrix form is: "); //Printing the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(" " + matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void SaveArrayToFile(string path)
        {

        }

        public static void ReadArray(string path)
        {

        }

        public static void AddNewArray(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            for (int i = 0; i < rows; i++) //Entering the elements of the matrix 
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Enter element ({i + 1},{j + 1}): ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
