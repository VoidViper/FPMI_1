using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {
                Console.WriteLine("Nqma da zakusnqvam poveche");
                i++;
            }
            while (i < 100);

            Console.ReadLine();
        }
    }
}
