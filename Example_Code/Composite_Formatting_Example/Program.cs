using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Formatting_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, adj, gotName;
            Console.Write("Color: ");
            color = Console.ReadLine();
            Console.Write("Adjective: ");
            adj = Console.ReadLine();
            Console.Write("Name a character from Game of Thrones: ");
            gotName = Console.ReadLine();

            Console.Write($"The sky is {color}. Macbooks are {adj}. It's me {gotName}!", color, adj, gotName);
            //drug nachin
            //Console.Write($"The sky is {0}. Macbooks are {1}. It's me {2}!", color, adj, gotName);
            Console.ReadLine();
        }
    }
}
