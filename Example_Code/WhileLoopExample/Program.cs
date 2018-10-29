using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int current = 1;

            while (current <= number)
            {
                Console.WriteLine(current);
                current++;
            }
            Console.ReadLine();
        }
    }
}
