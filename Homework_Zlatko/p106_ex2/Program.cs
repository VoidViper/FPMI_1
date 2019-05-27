using System;
//Homework by Georgi Gogov
//Page 106 / ex.2
namespace p106_ex2
{
    class Program
    {
        public static bool CheckPairSumEqual(int[] a, int x)
        {
            bool flag = false;
            int lowest = 0;
            int highest = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[lowest] + a[highest] > x) highest--;
                else if (a[lowest] + a[highest] < x) lowest++;
                else if (lowest != highest) return true;
            }
            return flag;
        }
        static void Main(string[] args)
        {
            int[] numArr = new int[10];
            
            Console.WriteLine("This program will check if there is a pair of numbers, which when added together,");
            Console.WriteLine("gives a sum equivelant to a number entered by the user.");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter a number for position {i+1}: ");
                numArr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter a number to check against: ");
            int numToFind = int.Parse(Console.ReadLine());
            if (CheckPairSumEqual(numArr, numToFind)) Console.WriteLine($"There is a pair whose sum is equal to {numToFind}");
            else Console.WriteLine($"There is no pair whose sum is equal to {numToFind}");
            
        }
    }
}
