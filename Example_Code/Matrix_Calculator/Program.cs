using System;

namespace Matrix_Calculator
{
    class Program
    {
        static void MatrixReadandPrint(int[,] matrix, int rows, int col)
        {
            for (int i = 0; i < rows; i++) //Entering the elements of the matrix 
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Enter element ({i + 1},{j + 1}): ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is: "); //Printing the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(" " + matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void MatrixAdd(int[,] matrixA, int[,] matrixB, int[,] Buffer)
        {
            Console.WriteLine("Addition");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(0); j++)
                {
                    Buffer[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                Console.Write("");
                for (int j = 0; j < matrixA.GetLength(0); j++)
                    Console.Write($" {Buffer[i, j]} ");
                Console.WriteLine();
            }
        }
        static void MatrixSub(int[,] matrixA, int[,] matrixB, int[,] Buffer)
        {
            Console.WriteLine("Subtraction");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(0); j++)
                {
                    Buffer[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                Console.Write("");
                for (int j = 0; j < matrixA.GetLength(0); j++)
                    Console.Write($" {Buffer[i, j]} ");
                Console.WriteLine();
            }
        }
        static void MatrixMultiply(int[,] matrixA, int[,] matrixB, int[,] Buffer)
        {
            for (int i = 0; i < matrixA.GetLength(0); i++)
                for (int j = 0; j < matrixB.GetLength(1); j++)
                    Buffer[i, j] = 0;
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrixA.GetLength(1); k++)
                        sum = sum + matrixA[i, k] * matrixB[k, j];
                    Buffer[i, j] = sum;
                }
            }
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                Console.Write("");
                for (int j = 0; j < matrixA.GetLength(0); j++)
                    Console.Write($" {Buffer[i, j]} ");
                Console.WriteLine();
            }
        }
        static void MatrixTranspose(int[,] matrix, string name)
        {
            Console.WriteLine($"Matrix {name} Transposed is:");
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(" " + matrix[j, i] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int rowsA, rowsB, colA, colB;
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
                MatrixReadandPrint(matrixA, rowsA, colA);

                Console.Write("Write the number of rows in Matrix B:");
                rowsB = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write the number of cols in Matrix B:");
                colB = Convert.ToInt32(Console.ReadLine());
                int[,] matrixB = new int[rowsB, colB];
                MatrixReadandPrint(matrixB, rowsB, colB);

                int[,] Buffer = new int[Math.Max(rowsA, rowsB), Math.Max(colA, colB)];

                Console.WriteLine("What operation would you like to perform? (+,-,*,t)");
                operation = Console.ReadLine();

                if ((rowsA != colA && rowsB != colB && colA == rowsB) || (rowsA == colA && rowsB != colB && colA == rowsB) || (rowsA != colA && rowsB == colB && colA == rowsB))
                {
                    if (operation == "*")
                    {
                        for (int i = 0; i < rowsA; i++)
                            for (int j = 0; j < colB; j++)
                                Buffer[i, j] = 0;
                        for (int i = 0; i < rowsA; i++)
                        {
                            for (int j = 0; j < colB; j++)
                            {
                                int sum = 0;
                                for (int k = 0; k < colA; k++)
                                    sum = sum + matrixA[i, k] * matrixB[k, j];
                                Buffer[i, j] = sum;
                            }
                        }
                        /*for (int i = 0; i < colA; i++)
                        {
                            Console.Write("");
                            for (int j = 0; j < colA; j++)
                                Console.Write($" {Buffer[i, j]} ");
                            Console.WriteLine();
                        }*/
                        for (int i = 0; i < rowsA; i++)
                        {
                            Console.Write("");
                            for (int j = 0; j < colB; j++)
                                Console.Write($" {Buffer[i, j]} ");
                            Console.WriteLine();
                        }
                    }
                    else if (operation == "t") //Transposing and printing both of the matrices i primer
                    {
                        MatrixTranspose(matrixA, "A");
                        MatrixTranspose(matrixB, "B");
                    }
                    else
                    {
                        Console.WriteLine("Error! Invalid operation. Exiting.");
                    }
                }
                else if (rowsA == colA && rowsB == colB && rowsA != colB)
                {
                    if (operation == "t")
                    {
                        MatrixTranspose(matrixA, "A");
                        MatrixTranspose(matrixB, "B");
                    }
                    else Console.WriteLine("Error! Invalid operation. Exiting.");
                }
                else if (rowsA == colA && rowsB == colB)
                {
                    if (operation == "+") //Adding the two matrices
                    {
                        MatrixAdd(matrixA, matrixB, Buffer);
                    }
                    else if (operation == "-") //Subtracting the two matrices
                    {
                        MatrixSub(matrixA, matrixB, Buffer);
                    }
                    else if (operation == "*") //Multiplying the two SQUARE matrices
                    {
                        MatrixMultiply(matrixA, matrixB, Buffer);
                    }
                    else if (operation == "t") //Transposing the two matrices
                    {
                        MatrixTranspose(matrixA, "A");
                        MatrixTranspose(matrixB, "B");
                    }
                }
                else if ((rowsA != colA && rowsB != colB)|| (rowsA == colA && rowsB != colB) || (rowsA != colA && rowsB == colB)) //edge case for 2 completely different matrices which can be transposed
                {
                    if (operation == "t") //Transposing and printing both of the matrices
                    {
                        MatrixTranspose(matrixA, "A");
                        MatrixTranspose(matrixB, "B");
                    }
                    else
                    {
                        Console.WriteLine("Error! Invalid operation. Exiting.");
                    }
                }
                else
                {
                    Console.WriteLine("Error! Invalid operation. Exiting.");
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
