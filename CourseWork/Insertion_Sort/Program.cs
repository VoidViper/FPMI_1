using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int numElements;
            Console.Write("Enter the amount of elements in the array: ");
            numElements = int.Parse(Console.ReadLine());
            int[] arr = new int[numElements];
            for (int i = 0; i < arr.Length; i++) //Enetering elements in the array
            {
                Console.Write($"Enter element {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length - 1; i++) //Insertion Sort
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
