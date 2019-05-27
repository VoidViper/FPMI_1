using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static bool Function(decimal[,] matrix, out decimal[] values)
        {
            values = new decimal[3];
            values[0] = matrix[0,0];
            values[1] = 0;
            values[2] = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (values[0]>matrix[i,j])
                    {
                        values[0] = matrix[i, j];
                        values[1] = Convert.ToDecimal(i);
                        values[2] = Convert.ToDecimal(j);
                    }
                }
            }
            if (values[0] > 0) return true;
            return false;
        }
        static void Main(string[] args)
        {
            decimal[] values = new decimal[3];
            decimal[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            
            if(Function(matrix, out values) == true)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine(values[i]);
                }
            }
        }
    }
}
