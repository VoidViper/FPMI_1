using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            bool doContinue = false;

            do
            {
                Console.Clear();
                Console.WriteLine("This program will let you do the following things:\n");
                Console.WriteLine("1.Add a new student");
                Console.WriteLine("2.Modify/Add grades to an existing student");
                Console.WriteLine("3.Print all the students, their faculty number and their average grade");
                Console.WriteLine("4.Make a file with all of the students' information");
                Console.WriteLine("5.Read a file with student information");
                Console.WriteLine("6.Sort the students by their faculty number");
                Console.WriteLine("7.Sort the students by their average grade in descending order");
                Console.WriteLine("8.List the information of a specific student by their faculty number\n");
                Console.Write("What operation would you like to perform? [Choose from 1 to 8]: ");
                var operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Student.AddStudent();
                        break;
                    case 2:
                        Student.AddGrades();
                        break;
                    case 3:
                        Student.PrintAllStudentInfo();
                        break;
                    case 4:
                        Student.MakeFile();
                        break;
                    case 5:
                        Student.ReadFile();
                        break;
                    case 6:
                        Student.SortByID();
                        break;
                    case 7:
                        Student.AvgGradeSort();
                        break;
                    case 8:
                        Student.PrintByID();
                        break;
                }

                Console.Write("Do you want to continue with a new operation? [y/n]: ");
                if (Console.ReadLine() == "y") doContinue = true;
                else doContinue = false;
            }
            while (doContinue);
        }
    }
}
