using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Enter the first number:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            y = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number:");
            z = int.Parse(Console.ReadLine());

            Console.WriteLine($"Result of the specified numbers {x}, {y} and {z}, (x+y).z is {(x+y)*z} and x.y + y.z is {(x*y)+(y*z)}");
        }
    }
}
