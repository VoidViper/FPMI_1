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
        static void MatrixCreateFromFile(int[,] matrix, int rows, int col)
        {
            if (File.Exists("matrix.txt"))
            {
                File.Open("matix.txt", FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("The file matrix.txt does not exist.");
            }

        }
        static void MatrixPrint(int[,] matrix, int rows, int col)
        { 
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
        static void Main(string[] args)
        {
            
            bool doContinue = false;

            do
            {
                int rows, col;
                Console.Write("Enter the size of the square matrix: ");
                int n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    rows = n;
                    col = n;
                    int[,] matrix = new int[rows, col]
;                   MatrixCreate(matrix, rows, col);
                }
                else
                {
                    Console.WriteLine("You have entered an invalid size for the square matrix. Try again with an integer greater than 0");
                }

                Console.Write("Do you want to continue? [y/n]: ");
                if (Console.ReadLine() == "y")
                {
                    doContinue = true;
                    Console.Clear();
                }
                else doContinue = false;
            }
            while (doContinue);
        }
    }
}
