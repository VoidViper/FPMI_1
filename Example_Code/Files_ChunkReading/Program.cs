using System;
using System.IO;

namespace Files_ChunkReading
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "data.dat";
            using(StreamWriter writer = new StreamWriter(fileName, false))
            {
                do
                {
                    Student student = new Student();
                    Console.Write("Name: ");
                    student.name = Console.ReadLine();
                    Console.Write("Faculty Num: ");
                    student.facNo = Console.ReadLine();

                    writer.Write();

                }
            }
        }
    }
}
