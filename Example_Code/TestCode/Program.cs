using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //terinary experiments
            int a, b;
            a = 0;
            b = 0;
            a = (5<2) ? 2 : 1;
            Console.WriteLine($"a={a}, b={b}");
        }
    }

}