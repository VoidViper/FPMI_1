using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            bool check;
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the secondt number: ");
            num2 = int.Parse(Console.ReadLine());

            if ((num1 > 0 && num2 < 0) || (num1 < 0 && num2 > 0))
            {
                check = true;
            }
            else check = false;
            Console.WriteLine($"Check if one is negative and one is positive: {check}");
        }
    }
}
