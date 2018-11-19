using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Student
    {
        public string Name;
        public int fNum;
        public int[] grades;
        public string gradesBufferSource = "";
        public string[] gradesBufferResult;
        bool correctGrade = false;

        public void AddStudent()
        {
            Console.Write("How many students would you like to add? : ");
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a faculty number: ");
                this.fNum = int.Parse(Console.ReadLine());

                Console.Write("Enter a name: ");
                this.Name = Console.ReadLine();
                Console.Write("Enter the student's grades with spaces in between them. [From 2 to 6 / max 40 grades]: ");
                gradesBufferSource = Console.ReadLine();
                gradesBufferResult = gradesBufferSource.Split(' ');

                for (int z = 0; z < gradesBufferResult.Length; z++) //converting the char[] gradesBufferResult to int[] grades
                {
                    grades[z] = int.Parse(gradesBufferResult[z]);
                }

                if (grades.Length <= 40)
                {
                    for (int j = 0; j < grades.Length; j++)
                    {
                        if (grades[j] >= 2 && grades[j] <= 6)
                        {
                            correctGrade = true;
                        }
                        else correctGrade = false;
                    }
                }
                else Console.WriteLine("The number of grades you have entered exceeds 40");
                if (correctGrade == false)
                {
                    Console.WriteLine("You have entered an invalid grade. Try again in the next itteration.");
                    n--;
                }
            }
            
        }
        public void AddGrades()
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will let you do the following things:\n");
            Console.WriteLine("1.Add a new student");
            Console.WriteLine("2.Modify/Add grades to an existing student");
            Console.WriteLine("3.Print all the students, their faculty number and their average grade");
            Console.WriteLine("4.Make a file with all of the students' information");
            Console.WriteLine("5.Read a file with student information");
            Console.WriteLine("6.Sort the students by their faculty number");
            Console.WriteLine("7.Sort the students by their average grade in descending order");
            Console.WriteLine("8.List the information of a specific student by their faculty number\n");
            
            bool doContinue = false;


            do
            {
                Console.Write("What operation would you like to perform? [Choose from 1 to 8]: ");
                var operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        AddGrades();
                        break;
                    case 3:
                        PrintAllStudentInfo();
                        break;
                    case 4:
                        MakeFile();
                        break;
                    case 5:
                        ReadFile();
                        break;
                    case 6:
                        SortByID();
                        break;
                    case 7:
                        AvgGradeSort();
                        break;
                    case 8:
                        PrintByID();
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
