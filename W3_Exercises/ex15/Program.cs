using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string randomString;
            Console.Write("Enter a string: ");
            randomString = Console.ReadLine();

            Console.WriteLine($"{randomString.Remove(1, 1)}"); //w3resource = wresource
            Console.WriteLine($"{randomString.Remove(9, 1)}"); //w3resource = w3resourc
            Console.WriteLine($"{randomString.Remove(0, 1)}"); //w3resource = 3resource
            // System.String.Remove ili <string>.Remove(int startIndex, int count); startIndex - index-a na chisloto ot koeto se zapochva, count - kolko elementa da iztrie
        }
    }
}
