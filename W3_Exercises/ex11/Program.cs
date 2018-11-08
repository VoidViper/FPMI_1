using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"You look older than: {age}");
        }
    }
}
