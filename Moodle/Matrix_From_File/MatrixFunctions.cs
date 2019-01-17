﻿using System;
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

        public static bool CheckIdentity(decimal[,] matrix) //W.I.P
        {
            bool isEdinichna = true;
            if (matrix.GetLength(0) == matrix.GetLength(1))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i == j && matrix[i,j] != 1)
                        {
                            isEdinichna = false;
                            break;
                        } 
                        if (i != j && matrix[i,j] != 0)
                        {
                            isEdinichna = false;
                            break;
                        }
                    }
                }
                if (isEdinichna) return true;
                if (!isEdinichna) return false;
            }
            else return false;
        }

        public static decimal SumNegativeOnAntiDiagonal(decimal[,] matrix)
        {
            return 0;
        }

        public static void NormalizeRows(ref decimal[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double SqrtSumOfSquaredElements = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    SqrtSumOfSquaredElements += Math.Sqrt(Convert.ToDouble(matrix[i, j]));
                }
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0) matrix[i, j] = Convert.ToDecimal(Convert.ToDouble(matrix[i, j]) / SqrtSumOfSquaredElements);
                }
            }
        }

        public static void SortMatrix(ref decimal[,] matrix)
        {

        }
    }
}