using System;

namespace Matrix_Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            int rowsA, rowsB, colA, colB;
            string operation;
            Console.WriteLine("This program adds, subtracts and multiplies matrices. If you enter a square matrix");
            Console.WriteLine("you will be able to add, subtract and multiply. If not, you will only see the matrices you've entered.");
            Console.WriteLine();
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
            if (rowsA == colA && rowsB == colB)
            {
                int[,] Buffer = new int[Math.Max(rowsA, rowsB), Math.Max(colA, colB)];
                int n = colA;

                Console.WriteLine("What operation would you like to perform? (+,-,*)");
                operation = Console.ReadLine();

                //Thanks to Mincho da brain
                if (operation == "+")
                {
                    Console.WriteLine("Addition");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Buffer[i, j] = matrixA[i, j] + matrixB[i, j];
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("");
                        for (int j = 0; j < n; j++)
                            Console.Write($"{Buffer[i, j]} ");
                        Console.WriteLine();
                    }
                }
                if (operation == "-")
                {
                    Console.WriteLine("Subtraction");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Buffer[i, j] = matrixA[i, j] - matrixB[i, j];
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("");
                        for (int j = 0; j < n; j++)
                            Console.Write($"{Buffer[i, j]} ");
                        Console.WriteLine();
                    }
                }
                if (operation == "*")
                {
                    Console.WriteLine("Multiplication to be added");
                }
            }
            else
            {
                Console.WriteLine("The matrices are not square. This is the end of the program");
            }

        }
    }
}
