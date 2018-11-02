using System;

namespace Matrix_Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            int rowsA, rowsB, colA, colB;
            int sum = 0;
            string operation;
            bool doContinue = false;

            Console.WriteLine("This program adds, subtracts, multiplies and transposes matrices. If you enter a square matrix");
            Console.WriteLine("you will be able to add, subtract, transpose and multiply. If not, you won't be able to multiply.");
            Console.WriteLine();

            do
            {
                Console.Write("Write the number of rows in Matrix A:");
                rowsA = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write the number of cols in Matrix A:");
                colA = Convert.ToInt32(Console.ReadLine());
                int[,] matrixA = new int[rowsA, colA];

                for (int i = 0; i < rowsA; i++) //Entering the elements of matrix A
                {
                    for (int j = 0; j < colA; j++)
                    {
                        Console.Write($"Enter element ({i + 1},{j + 1}): ");
                        matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("MatrixA is: "); //Printing matrix A
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
                for (int i = 0; i < rowsB; i++) //Entering the elements of matrix B
                {
                    for (int j = 0; j < colB; j++)
                    {
                        Console.Write($"Enter element ({i + 1},{j + 1}): ");
                        matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("MatrixB is: "); //Printing matrix A
                for (int i = 0; i < rowsB; i++)
                {
                    for (int j = 0; j < colB; j++)
                    {
                        Console.Write(" " + matrixB[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                int[,] Buffer = new int[Math.Max(rowsA, rowsB), Math.Max(colA, colB)];
                int n = colA;
                Console.WriteLine("What operation would you like to perform? (+,-,*,t)");
                operation = Console.ReadLine();
                if (rowsA != colA && rowsB != colB && colA == rowsB)
                {
                    if (operation == "*")
                    {
                        /*for (int i = 0; i < rowsA; i++)
                            for (int j = 0; j < colB; j++)
                                Buffer[i, j] = 0;
                        for (int i = 0; i < rowsA; i++)    
                        {
                            for (int j = 0; j < colB; j++)    
                            {
                                sum = 0;
                                for (int k = 0; k < colA; k++)
                                    sum = sum + matrixA[i, k] * matrixB[k, j];
                                Buffer[i, j] = sum;
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("");
                            for (int j = 0; j < n; j++)
                                Console.Write($" {Buffer[i, j]} ");
                            Console.WriteLine();
                        }*/
                        Console.WriteLine("Not square matrix multiplication WIP");
                    }
                    else if (operation == "t") //Transposing and printing both of the matrices
                    {
                        Console.WriteLine("Matrix A Transposed is:");
                        for (int i = 0; i < colA; i++)
                        {
                            for (int j = 0; j < rowsA; j++)
                            {
                                Console.Write(" " + matrixA[j, i] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("Matrix B Transposed is:");
                        for (int i = 0; i < colB; i++)
                        {
                            for (int j = 0; j < rowsB; j++)
                            {
                                Console.Write(" " + matrixB[j, i] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation!");
                    }
                }
                else if (rowsA == colA && rowsB == colB)
                {
                    //Thanks to Mincho da brain
                    if (operation == "+") //Adding the two matrices
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
                                Console.Write($" {Buffer[i, j]} ");
                            Console.WriteLine();
                        }
                    }
                    if (operation == "-") //Subtracting the two matrices
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
                                Console.Write($" {Buffer[i, j]} ");
                            Console.WriteLine();
                        }
                    }
                    if (operation == "*") //Multiplying the two SQUARE matrices
                    {
                        for (int i = 0; i < rowsA; i++)
                            for (int j = 0; j < colB; j++)
                                Buffer[i, j] = 0;
                        for (int i = 0; i < rowsA; i++)
                        {
                            for (int j = 0; j < colB; j++)
                            {
                                sum = 0;
                                for (int k = 0; k < colA; k++)
                                    sum = sum + matrixA[i, k] * matrixB[k, j];
                                Buffer[i, j] = sum;
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("");
                            for (int j = 0; j < n; j++)
                                Console.Write($" {Buffer[i, j]} ");
                            Console.WriteLine();
                        }
                    }
                    if (operation == "t") //Transposing the two matrices
                    {
                        Console.WriteLine("Matrix A Transposed is:");
                        for (int i = 0; i < colA; i++)
                        {
                            for (int j = 0; j < rowsA; j++)
                            {
                                Console.Write(" " + matrixA[j, i] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("Matrix B Transposed is:");
                        for (int i = 0; i < colB; i++)
                        {
                            for (int j = 0; j < rowsB; j++)
                            {
                                Console.Write(" " + matrixB[j, i] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error! Cannot do operations on these matrices. Exiting.");
                }

                Console.Write("Do you want to continue? [y/n]: ");
                if (Console.ReadLine() == "y")
                {
                    doContinue = true;
                }
                else doContinue = false;
            }
            while (doContinue == true);
            
           
            
        }
    }
}
