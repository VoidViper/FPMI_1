using System;
using System.IO;

namespace Matrix_From_File
{
    public class MatrixReader
    {
        public static void ReadMatrix(string path, ref decimal[,] outputMatrix)
        {
            int rows = 0, cols = 0;
            if (File.Exists(path))
            {
                using (StreamReader myReader = new StreamReader(path))
                {
                    rows = int.Parse(myReader.ReadLine());
                    cols = int.Parse(myReader.ReadLine());
                    decimal[,] matrix = new decimal[rows, cols];

                    var readToEndBuffer = myReader.ReadToEnd();

                    string[] Buffer = readToEndBuffer.Split(new string[] { " ", Environment.NewLine }, StringSplitOptions.None);
                    int pos = 0;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            matrix[i, j] = Convert.ToDecimal(Buffer[pos]);
                            pos++;
                        }
                    }
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            outputMatrix[i,j] = matrix[i,j];
                        }
                    }
                }
            }
            else Console.WriteLine("File does not exist!");
        }
    }
}
