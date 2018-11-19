using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr, buffer;
            
            Console.Write("Enter the amount of elements in the array: ");
            arr = new int[int.Parse(Console.ReadLine())];
            buffer = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] <= arr[i+1])
                {
                    buffer[i] = arr[i];
                }
            }
        }
    }
}
