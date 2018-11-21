﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Student
    {
        public static void AddStudent()
        {
            Console.Write("How many students would you like to add? : ");
            var n = int.Parse(Console.ReadLine());
            string[] Name = new string[n];
            string[] fNum = new string[n];
            string gradesBufferSource = "", gradesString = "";
            string[] gradesBufferResult;
            double[] grades = new double[40];            
            string[] contents = new string[n];
            bool correctGrade = false;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter a name for student {i + 1}: ");
                Name[i] = Console.ReadLine();
                Console.Write($"Enter a faculty number for student {i + 1}: ");
                fNum[i] = Console.ReadLine();
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

                contents[i] = (Name[i] + "_" + fNum[i] + "_" + gradesString);
                File.AppendAllLines("buffer.txt", contents);
            }           


        }
        public static void AddGrades()
        {
            Console.WriteLine("W.I.P");
        }
        public static void PrintAllStudentInfo()
        {
            Console.WriteLine("W.I.P");
        }
        public static void MakeFile() //Da se zapisva informaciqta ot drugite funkcii pod nqkuv format e.g Name: {name}, FakNum: {fakNum}, ..
        {
            string path;
            Console.WriteLine("Enter a directory where you would like to have the list of students stored.");
            Console.WriteLine("[e.g. C:\\Users\\Admin\\Desktop\\storage.txt]");
            Console.Write("Path: ");
            path = Console.ReadLine();
            Console.Write("What would you like it to say : ");
            //File.WriteAllLines(path, contents);
        }
        public static void ReadFile() //Da se chete file-a ot formata i da se vkarva informaciqta v masivite za da se raboti s neq
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
        public static void SortByID() //Implement Selection Sort Algorithm
        {
            Console.WriteLine("W.I.P");
        }
        public static void AvgGradeSort() //Implement Insertion Sort Algorithm by average grade
        {
            Console.WriteLine("W.I.P");
        }
        public static void PrintByID()
        {
            Console.WriteLine("W.I.P");
        }
    }
}
