using System;
//Homework by Georgi Gogov
//Page 28 / ex.12

namespace p28_ex12
{
    class Program
    {
        public static bool checkPalindrome(string wordToCheck)
        {
            char[] charArr = wordToCheck.ToCharArray();
            int counter = wordToCheck.Length - 1;
            bool flag = false;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] != charArr[counter]) flag = true;
                counter--;
            }
            return flag;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a palindrome: ");
            string word = Console.ReadLine();
            if (!checkPalindrome(word)) Console.WriteLine("The word is indeed a palindrome");
            else Console.WriteLine("The word you have entered is not a palindrome");
        }
    }
}
