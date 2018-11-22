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
        string Name, fNum;
        string gradesBufferSource = "", gradesString = "";
        string[] gradesBufferResult;
        double[] grades = new double[40];
        string contents;
        int amountOfGrades;
        double avgGrade = 0;

        public void AddStudent() //redundant ?
        {
            AddStudentInfo();
        }
        public void AddStudentInfo()
        {
            StreamWriter myWriter = new StreamWriter("buffer.txt", true);

            Console.Write("Enter a name for the student: ");
            this.Name = Console.ReadLine();
            Console.Write("Enter a faculty number for the student: ");
            this.fNum = Console.ReadLine();
            Console.Write("Enter how many grades would you like to enter: "); //In the future just call AddGrades();
            this.amountOfGrades = int.Parse(Console.ReadLine());
            Console.Write("Enter the student's grades with spaces in between them. [From 2 to 6]: ");
            this.gradesBufferSource = Console.ReadLine();
            this.gradesBufferResult = this.gradesBufferSource.Split(' ');

            for (int z = 0; z < gradesBufferResult.Length; z++) //converting the string[] gradesBufferResult to double[] grades to make checks
            {
                this.grades[z] = double.Parse(gradesBufferResult[z]);
            }
            
            /*if (amountOfGrades <= 40 && grades.Length == amountOfGrades) //check for valid input for grades
            {
                bool flag = true;
                bool[] gradesTrueFalse = new bool[40];

                for (int i = 0; i < grades.Length; i++)
                {
                    if ((grades[i] >= 2) && (grades[i] <= 6))
                        gradesTrueFalse[i] = true;
                    else gradesTrueFalse[i] = false;
                }
                for (int i = 0; i < gradesTrueFalse.Length; i++)
                {
                    if (gradesTrueFalse[i] == false)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == false) Console.WriteLine("You have entered an invalid grade. Try again.");
                else
                {*/
                    for (int i = 0; i < this.gradesBufferResult.Length; i++) //converting the array of grades to a single string without spaces for storage in a file
                    {
                        this.gradesString = this.gradesString + this.gradesBufferResult[i];
                    }
                    this.contents = this.Name + "_" + this.fNum + "_" + this.gradesString;
                /*}
            }
            else Console.WriteLine("The number of grades you have entered exceeds 40");*/
            
            
            myWriter.WriteLine(contents);
            myWriter.Close();
            this.gradesString = "";
        }
        public void AddGrades()
        {
            Console.Write("Enter how many grades would you like to enter: ");
            this.amountOfGrades = int.Parse(Console.ReadLine());
            Console.Write("Enter the student's grades with spaces in between them. [From 2 to 6]: ");
            this.gradesBufferSource = Console.ReadLine();
            this.gradesBufferResult = this.gradesBufferSource.Split(' ');
            for (int i = 0; i < this.gradesBufferResult.Length; i++) //converting the array of grades to a single string without spaces for storage in a file
            {
                this.gradesString = this.gradesString + this.gradesBufferResult[i];
            }
            this.contents = this.contents + this.gradesString;
            this.gradesString = "";
        }
        public void PrintAllStudentInfo()
        {
            /*for (int i = 0; i < grades.Length; i++)//get average grade
            {
                
            }
            */
            Console.Write($"Student information:");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Faculty number: {this.fNum}");
            Console.WriteLine($"Average grade: {this.avgGrade}");
            Console.WriteLine("-----------------------------");
            
        }
        public void MakeFile() //Da se zapisva informaciqta ot drugite funkcii pod nqkuv format e.g {name}_{fakNum}_{avgGrade}
        {
            string path;
            Console.WriteLine("Enter a directory where you would like to have the list of students stored.");
            Console.WriteLine("[e.g. C:\\Users\\Admin\\Desktop\\storage.txt]");
            Console.Write("Path: ");
            path = Console.ReadLine();
            Console.Write("What would you like it to say : ");
            //File.WriteAllText(path, "buffer.txt");
        }
        public void ReadFile() //Da se chete file-a pod nqkuv format e.g {name}_{fakNum}_{avgGrade} i da se vkarva informaciqta v masivite za da se raboti s neq
        {
            Console.WriteLine("This program checks if a file exists and if it does, it opens it.");
            Console.WriteLine("Enter the path of the file [e.g.C:\\Users\\Admin\\Desktop\\storage.txt]");
            Console.Write("Path: ");
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                string ToRead = File.ReadAllText(path);
                Console.WriteLine(ToRead);
            }
            else Console.WriteLine("The file does not exist.");
        }
        public void SortByID() //Implement Selection Sort Algorithm
        {
            Console.WriteLine("W.I.P");
        }
        public void AvgGradeSort() //Implement Insertion Sort Algorithm by average grade
        {
            Console.WriteLine("W.I.P");
        }
        public void PrintByID()
        {
            Console.WriteLine("W.I.P");
        }
    }
}