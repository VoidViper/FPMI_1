using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int a, e, i, o, u, sumVowels = 0;
            a = 1;
            e = 2;
            i = 3;
            o = 4;
            u = 5;
            Console.Write("Write a string: ");
            input = Console.ReadLine();
            char[] letterArr = input.ToCharArray();

            for (int n = 0; n < input.Length; n++)
            {
                switch (letterArr[n])
                {
                    case 'a':
                        sumVowels += a;
                        break;
                    case 'e':
                        sumVowels += e;
                        break;
                    case 'i':
                        sumVowels += i;
                        break;
                    case 'o':
                        sumVowels += o;
                        break;
                    case 'u':
                        sumVowels += u;
                        break;
                }
            }
            Console.WriteLine($"The sum of the vowels in the word {input} is {sumVowels}");

            Console.ReadLine();
        }
    }
}
