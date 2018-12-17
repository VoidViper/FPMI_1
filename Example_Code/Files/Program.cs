using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "data.dat";
            string name;
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    name = reader.ReadToEnd();
                }                
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    Console.Write("Your name: ");
                    name = Console.ReadLine();

                    writer.Write(name);
                }
            }

            Console.WriteLine($"Hello {name}!");
        }
    }
}
