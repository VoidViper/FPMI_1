using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            Console.WriteLine("This program checks if a file exists and if it does, it opens it.");
            Console.Write("Enter the path of the file:");
            path = Console.ReadLine();
            if (File.Exists(path))
            {
                string ToRead = File.ReadAllText(path);
                Console.WriteLine(ToRead);
            }
            else Console.WriteLine("The file does not exist.");
        }
    }
}
