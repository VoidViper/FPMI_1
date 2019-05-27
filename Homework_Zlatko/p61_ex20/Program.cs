using System;
//Homework by Georgi Gogov
//Page 61 / ex.20

namespace p61_ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will find the highest and lowest value in a non-emptry binary tree.");
            Console.WriteLine("The binary tree has fifteen values.");
            int[] numArr = new int[15];
            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Please enter a value for slot [{i}]: ");
                numArr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Please enter a number to be found: ");
            int numToFind = int.Parse(Console.ReadLine());
            Unit root = null;
            Tree binTree = new Tree();
            for (int i = 0; i < numArr.Length; i++)
            {
                root = binTree.Insert(root, numArr[i]);
            }
            Console.WriteLine($"The lowest value in the tree is {binTree.MinVal(root)}");
            Console.WriteLine($"The highest value in the tree is { binTree.MaxVal(root)}");
            if (binTree.Search(root, numToFind))
                Console.WriteLine($"{numToFind} has been found");
            else Console.WriteLine($"{numToFind} has not been found");

        }
    }
}
