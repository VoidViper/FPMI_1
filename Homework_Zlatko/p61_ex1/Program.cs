using System;
//Homework by Georgi Gogov
//Page 61 / ex.1

namespace p61_ex1
{
    class Program
    {
        static bool parenthesesTrue(string parentheses)
        {
            int count = 0;
            if (parentheses.Length <= 1)
                return false;
            for (int i = 0; i < parentheses.Length; i++)
            {
                if (parentheses[i].Equals('('))
                    count++;
                else if (parentheses[i].Equals(')'))
                {
                    count--;
                    if (count < 0)
                        return false;
                }
            }
            return (count == 0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a test string: ");
            string test = Console.ReadLine();
            if (parenthesesTrue(test)) Console.WriteLine("Correct parentheses!");
            else Console.WriteLine("Incorrect parentheses!");
        }
    }
}
