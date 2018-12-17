using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Exceptions
{
    class Program
    {
        enum ResultCode
        {
            Success=0, ArgumentNull, Unknown
        }
        ResultCode MatrixOnMainDiag(decimal [,] m, out decimal result)
        {
            if (m != null)
            {
                var max = m[0, 0];
                for (int i = 0; i < m.GetLength(0); i++)
                    if (m[i, i] > max) max = m[i, i];
                result = max;
                return ResultCode.Success;
            }
            result = 0;
            return ResultCode.ArgumentNull;
        }
        static void Main(string[] args)
        {
            decimal[,] m = null;
            int choice;
            do
            {
                Console.WriteLine("1. Insert; 2.MaxOnMainDiag");
                choice = ReadInt("Insert a choice: ");
                switch (choice)
                {
                    case 1:
                        m = ReadMatrix(ReadInt("n="));
                        break;
                    case 2:
                        decimal max;
                        var result = MaxOnMainDiag(m, out max);
                        if (result == ResultCode.Success)
                            Console.WriteLine(max);
                        else if (result == ResultCode.ArgumentNull)
                            Console.WriteLine("Please insert a matrix");
                        else Console.WriteLine("An error has occured");
                        break;
                }
            }
        }
    }
}
