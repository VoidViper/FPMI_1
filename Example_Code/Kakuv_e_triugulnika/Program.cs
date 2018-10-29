using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakuv_e_triugulnika
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b=");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c=");
            c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && a != c && b != c) Console.WriteLine("Triugulnikut e ravnobedren s beda a i b");

                else if (b == c && b != a && c != a) Console.WriteLine("Trigulnikut e ravnobedren s bedra b i c");

                else if (a == c && a != b && c != b) Console.WriteLine("Trigulnikut e ravnobedren s bedra a i c");

                else if (a != b && a != c && b != c) Console.WriteLine("Trigulnikut e raznostranen");

                else if (a == b && a == c && b == c) Console.WriteLine("Trigulnikut e ravnostranen");
            }
            else Console.WriteLine("Triugulnikut e nevuzmojen");

            Console.ReadLine();
        }
    }
}
