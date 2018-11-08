using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, second;
            char[] arrayA, arrayB;
            char bufferA, bufferB;

            first = Console.ReadLine();
            arrayA = first.ToCharArray();
            second = Console.ReadLine();
            arrayB = second.ToCharArray();

            bufferA = arrayA[0];
            arrayA[0] = arrayA[arrayA.Length-1];
            arrayA[arrayA.Length-1] = bufferA;

            bufferB = arrayB[0];
            arrayB[0] = arrayB[arrayB.Length-1];
            arrayB[arrayB.Length-1] = bufferB;

            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.Write(arrayA[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arrayB.Length; i++)
            {
                Console.Write(arrayB[i]);
            }
            Console.WriteLine();
        }
    }
}
