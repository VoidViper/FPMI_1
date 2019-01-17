using System;
using System.IO;
namespace Matrix_From_File
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the path to the file:");
            string path = Console.ReadLine();

            StreamReader myReader = new StreamReader(path);
            int rows = int.Parse(myReader.ReadLine());
            int cols = int.Parse(myReader.ReadLine());
            decimal[,] matrix = new decimal[rows, cols];
            myReader.Close();

            Menu.PrintMenu(path,ref matrix);
        }
    }
}
