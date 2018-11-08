using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            Console.Write("Enter the amount of celsius: ");
            celsius = double.Parse(Console.ReadLine());

            Console.WriteLine($"Kelvin = {celsius + 273.15}");
            Console.WriteLine($"Fahrenheit = {(celsius*1.8) + 32}");
        }
    }
}
