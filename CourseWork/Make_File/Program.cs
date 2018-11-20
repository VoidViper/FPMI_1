using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a directory where you would like to have the list of students stored.");
            Console.WriteLine("[e.g. C:\\Users\\Admin\\Desktop\\storage.txt]");
            Console.Write("Path: ");
            string path = Console.ReadLine();
            Console.Write("What would you like it to say : ");
            string ToWrite = Console.ReadLine();
            File.WriteAllText(path,ToWrite);
        }
    }
}
