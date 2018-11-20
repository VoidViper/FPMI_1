using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Student_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumOfStudents = 3;
            int[] fakNum = {181218002, 181218006, 181218001 };
            double[] avgGrade = { 4.33, 5.60, 6.00 };
            string[] studentList = {"Ivan Petrov", "Teodor Yanakiev", "Petar Novakov" };

            Console.WriteLine("List of students:");
            Console.WriteLine();
            for (int i = 0; i < NumOfStudents; i++)
            {
                Console.WriteLine($"Name: {studentList[i]}");
                Console.WriteLine($"Faculty Number: {fakNum[i]}");
                Console.WriteLine($"Average Grade: {avgGrade[i]}");
                Console.WriteLine("-----------------------------");
            }

        }
    }
}
