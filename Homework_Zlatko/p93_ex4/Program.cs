using System;
//Homework by Georgi Gogov
//Page 93 / ex.6

namespace p93_ex4
{
    class Program
    {
        static int counter = 1;
        static int mouseX = 1;
        static int mouseY = 1;  
        static int cheeseX = 3;
        static int cheeseY = 2;

        public static int[,] maze = 
        {
            { 0, 0, 0, 0 },
            { 0, 0, 1, 0 },
            { 0, 1, 1, 0 },
            { 0, 0, 0, 0 }
        };
        public static int[,] solution =
        {   
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 }
        };
        public static void FindPath(int mouseX, int mouseY, int[,] sol)
        {
            if (!ValidCell(mouseX, mouseY)) return;
            if (mouseX == cheeseX && mouseY == cheeseY)
            {
                sol[mouseX, mouseY] = 9;
                Console.WriteLine("Solution " + (counter++));
                Sol(sol);
                Console.WriteLine();
            }
            else if (ValidCell(mouseX, mouseY))
            {
                maze[mouseX, mouseY] = 1;
                sol[mouseX, mouseY] = 1;
                FindPath(mouseX + 1, mouseY, sol);
                FindPath(mouseX - 1, mouseY, sol);
                FindPath(mouseX, mouseY + 1, sol);
                FindPath(mouseX, mouseY - 1, sol);
                maze[mouseX, mouseY] = 0;
            }
            sol[mouseX, mouseY] = 0;
        }

        public static bool ValidCell(int x, int y)
        {
            if (x < 0 || x >= maze.GetLength(0))
                return false;
            if (y < 0 || y >= maze.GetLength(0))
                return false;
            if (maze[x, y] == 1)
                return false;
            return true;
        }
        public static void Sol(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            FindPath(mouseX, mouseY, solution);
        }
    }
}
