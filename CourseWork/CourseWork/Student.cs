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

        public void AddStudent()
        {
            bool correctGrade = false;
            StreamWriter myWriter = new StreamWriter("buffer.txt", true);

            Console.Write($"Enter a name for the student: ");
            Name = Console.ReadLine();
            Console.Write($"Enter a faculty number for the student: ");
            fNum = Console.ReadLine();
            Console.Write($"Enter the student's grades with spaces in between them. [From 2 to 6 / max 40 grades]: ");
            gradesBufferSource = Console.ReadLine();
            gradesBufferResult = gradesBufferSource.Split(' ');

            for (int z = 0; z < gradesBufferResult.Length; z++) //converting the string[] gradesBufferResult to double[] grades to make checks
            {
                grades[z] = double.Parse(gradesBufferResult[z]);
            }
            for (int k = 0; k < gradesBufferResult.Length; k++) //converting the array of grades to a single string without spaces for storage in a file
            {
                gradesString = gradesString + gradesBufferResult[k];
            }
            contents = Name + "_" + fNum + "_" + gradesString;
            
            myWriter.WriteLine(contents);
            myWriter.Close();
        }
        public void AddGrades()
        {
            Console.WriteLine("W.I.P");
        }
        public void PrintAllStudentInfo()
        {
            /*for (int i = 0; i < grades.Length; i++)//get average grade
            {
                
            }
            
            Console.Write($"Student {i} information:");
            Console.WriteLine($"Name: {Name[i]}");
            Console.WriteLine($"Faculty number: {fNum[i]}");
            Console.WriteLine($"Average grade: {avgGrade[i]}");
            Console.WriteLine("-----------------------------");
            */
        }
        public void MakeFile() //Da se zapisva informaciqta ot drugite funkcii pod nqkuv format e.g Name: {name}, FakNum: {fakNum}, ..
        {
            string path;
            Console.WriteLine("Enter a directory where you would like to have the list of students stored.");
            Console.WriteLine("[e.g. C:\\Users\\Admin\\Desktop\\storage.txt]");
            Console.Write("Path: ");
            path = Console.ReadLine();
            Console.Write("What would you like it to say : ");
            //File.WriteAllLines(path, contents);
        }
        public void ReadFile() //Da se chete file-a ot formata i da se vkarva informaciqta v masivite za da se raboti s neq
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