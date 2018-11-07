using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if(( i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FooBar");
                }
                else if (i % 3 == 0) Console.WriteLine("Foo");
                else if (i % 5 == 0) Console.WriteLine("Bar");
                else Console.WriteLine(i);
            }
        }
    }
}
