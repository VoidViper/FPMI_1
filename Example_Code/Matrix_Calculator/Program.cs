using System;

namespace Matrix_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsA, rowsB, colA, colB;
            string operation;

            Console.Write("Write the number of rows in Matrix A:");
            rowsA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write the number of cols in Matrix A:");
            colA = Convert.ToInt32(Console.ReadLine());
            int[,] matrixA = new int[rowsA, colA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    Console.Write($"Enter element ({i},{j}): ");
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("MatrixA is: ");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    Console.Write(" " + matrixA[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Write the number of rows in Matrix B:");
            rowsB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write the number of cols in Matrix B:");
            colB = Convert.ToInt32(Console.ReadLine());
            int[,] matrixB = new int[rowsB, colB];
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    Console.Write($"Enter element ({i},{j}): ");
                    matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("MatrixB is: ");
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    Console.Write(" " + matrixB[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("What operation would you like to perform? (+,-,*)");
            operation = Console.ReadLine();

            /*
            switch (operation)
            {
                case "+":
                    MatrixAdd;
                    break;
                case "-":
                    MatrixSub;
                    break;
                case "*":
                    MatrixMultiply();
                    break;
            }
            */
            Console.ReadLine();

        }
    }
}
