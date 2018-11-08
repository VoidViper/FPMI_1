using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Input the first number to multiply: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the first second to multiply: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Input the first third to multiply: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} x {num2} x {num3} = {num1*num2*num3}");
        }
    }
}
