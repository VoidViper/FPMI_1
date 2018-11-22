using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Functions
    {
        static void SwapElements(int element1, int element2, int[] arr)
        {
            int temp = arr[element1];
            arr[element1] = arr[element2];
            arr[element2] = temp;
        }
        static void SelectionSort(int[] arr)
        {
            int smallestElement;
            for (int i = 0; i < arr.Length; i++)
            {
                smallestElement = i;
                for (int index = i + 1; index < arr.Length; index++)
                {
                    if (arr[index] < arr[smallestElement])
                    {
                        smallestElement = index;
                    }
                }
                SwapElements(i, smallestElement, arr);
            }
        }

        public void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++) 
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
        }

        public static double getAverageGrade(double[] arr)
        {
            double average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                average = average + arr[i];
            }
            average = average / arr.Length;

            return average;
        }

    }
}
