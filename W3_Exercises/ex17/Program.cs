using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            string rndString;
            Console.Write("Input a string: ");
            rndString = Console.ReadLine();

            if(rndString.Length >= 1)
            {
                Console.WriteLine($"{rndString[0]}{rndString}{rndString[0]} ");
            }
            else
            {
                Console.WriteLine("The string is not longer than 1");
            }
        }
    }
}
