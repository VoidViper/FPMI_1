using System;
using System.IO;

namespace Posledna_Lekciq
{
    public class Functions
    {
        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int value = arr[i];
                int k = i;
                while (k > 0 && arr[k-1] >= value)
                {
                    arr[k] = arr[k - 1];
                    --k;
                }
                arr[k] = value;
            }
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[k] < arr[minIndex])
                        minIndex = k;
                }
                if (minIndex != i)
                {
                    var temp = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        public static void BubbleSort(int[] arr)
        {
            bool sorted;
            do
            {
                sorted = true;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        SwapElements(ref arr[i - 1], ref arr[i]);
                    }
                    sorted = false;
                }
            }
            while (!sorted);
        }
        private static void SwapElements(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
