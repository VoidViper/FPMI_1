using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int numArr;
            Console.Write("Enter the number of elements in your array: ");
            numArr = Convert.ToInt32(Console.ReadLine());
            int[] intArr = new int[numArr];

            for (int i = 0; i < numArr; i++)
            {
                Console.Write($"Enter the value for element {i}: ");
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int minVal = intArr[0];

            foreach (int element in intArr)
            {
                if (element < minVal)
                {
                    minVal = element;
                }
            }
            Console.WriteLine($"The minimum value of the element in the array is: {minVal}");
            Console.ReadLine();
        }
    }
}
