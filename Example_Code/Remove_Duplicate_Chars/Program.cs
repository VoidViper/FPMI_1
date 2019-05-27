using System;
using System.Linq;
using System.Collections.Generic;

namespace Remove_Duplicate_Chars
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Console.Write("Enter a string: ");
            string str = Console.ReadLine();


            string nStr = str[0].ToString();

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] != str[i]) 
                nStr += str[i];
            }

            Console.WriteLine(nStr);*/

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            List<char> nstr = str.ToList();

            for (int i = 1; i < nstr.Count(); i++)
            {
                if (nstr[i - 1] == nstr[i]) 
                {
                    nstr.RemoveAt(i--);

                }

            }
            Console.WriteLine(String.Join("", nstr));
        }
    }
}
