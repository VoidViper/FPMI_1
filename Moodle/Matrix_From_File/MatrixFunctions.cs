using System;
namespace Matrix_From_File
{
    public class MatrixFunctions
    {
        public static void PrintMatrix(decimal[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" " + matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool CheckIdentity()
        {
            return false;
        }

        public static decimal SumNegativeOnAntiDiagonal()
        {
            return 0;
        }

        public static void NormalizeRows()
        {

        }

        public static void SortMatrix()
        {

        }
    }
}
