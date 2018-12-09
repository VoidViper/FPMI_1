using System;
using System.IO;

namespace Matrix_from_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of the square Matrix : ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int sumOddElements = 0;
            int sumEvenElements = 0;

            for (int row = 0; row < n; row++) //Initializing the elements in the matrix with -1
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = -1;
                }
            }

            if (File.Exists("matrix.txt"))
            {
                StreamReader myReader = new StreamReader("matrix.txt"); //Creating a StreamReader to read all of the contents of the file
                myReader = File.OpenText("matrix.txt");
                string content = myReader.ReadToEnd();
                myReader.Close();

                string[] matrixElements = content.Split(new string[] { "\t" }, StringSplitOptions.None);

                for (int i = 2; i < matrixElements.Length; i += 3)
                {
                    if (matrixElements[i] == "") matrixElements[i] = "-1";
                }

                int[] intElements = new int[matrixElements.Length];
                for (int i = 0; i < matrixElements.Length; i++)
                {
                    intElements[i] = int.Parse(matrixElements[i]);
                }

                for (int i = 0; i < intElements.Length; i++)
                {
                    if (intElements[i] % 2 == 0) sumEvenElements += intElements[i];
                    else sumOddElements += intElements[i];
                }
                Console.WriteLine($"The sum of the even elements is {sumEvenElements}");
                Console.WriteLine($"The sum of the odd elements is {sumOddElements}");

                //To do: Sum of elements in even rows and odd cols
            }
            else Console.WriteLine("The file matrix.txt does not exist.");
        }
    }
}
