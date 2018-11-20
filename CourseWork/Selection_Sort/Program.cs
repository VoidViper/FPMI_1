using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void SwapElements (int element1,int element2, int[] arr)
        {
            int temp = arr[element1];
            arr[element1] = arr[element2];
            arr[element2] = temp;
        }
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
            
            int smallestElement;
            for (int i = 0; i < arr.Length; i++)
            {
                smallestElement = i;
                for (int index = i + 1; index < arr.Length ; index++)
                {
                    if (arr[index] < arr[smallestElement])
                    {
                        smallestElement = index;
                    }
                    SwapElements(i, smallestElement, arr);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
