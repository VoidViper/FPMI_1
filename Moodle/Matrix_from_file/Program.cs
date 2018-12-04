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
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            int rows = N, cols = N;
            int[,] matrix = new int[rows,cols];


            if (File.Exists("matrix.txt"))
            {
                var myReader = new StreamReader("matrix.txt");

                myReader = File.OpenText("matrix.txt");

                string content;
                using (StreamReader reader = new StreamReader())
                {
                    content = reader.ReadToEnd();
                }
                /*while ((elements = myReader.ReadLine()) != null)
                {
                    characters = elements.ToCharArray();
                }*/

                for (int k = 0; k < matrix.Length; k++)
                {
                    
                    /*for (int i = 0; i < rows; i++) //Entering the elements of the matrix 
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write($"Enter element ({i + 1},{j + 1}): ");
                            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }*/
                }
                myReader.Close();
            }

            else
            {
                Console.WriteLine("The matrix.txt file does not exist. Please supply a valid matrix.txt file.");
            }
        }
    }
}
