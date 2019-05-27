using System;
//Homework by Georgi Gogov
//Page 93 / ex.6

namespace p93_ex6
{
    class Program
    {
        static void findApples (string currPath, ref string endPath, int currResult, ref int finalResult, int row, int col, int[,] field, int posX, int posY)
        {
            if (posX == row - 1 && posY == col - 1)
            {
                if (currResult >= finalResult)
                {
                    finalResult = currResult;
                    currPath = currPath.Substring(0, currPath.Length - 1);
                    endPath = currPath;
                }
                currResult = 0;
                currPath = "";
                return;
            }
            if (posX == row - 1)
            {
                currResult += field[posX, posY];
                findApples(currPath += " Right ", ref endPath, currResult, ref finalResult, row, col, field, posX, posY + 1);
                return;
            }
            if (posY == col - 1)
            {
                currResult += field[posX, posY];
                findApples(currPath + " Down ", ref endPath, currResult, ref finalResult, row, col, field, posX + 1, posY);
                return;
            }
            currResult += field[posX, posY];
            findApples(currPath + " Right ", ref endPath, currResult, ref finalResult, row, col, field, posX, posY + 1);
            findApples(currPath + " Down ", ref endPath, currResult, ref finalResult, row, col, field, posX + 1, posY);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("This program will tell you the maximum amount of apples you can collect");
            Console.WriteLine("On a given board of 4 by 6 squares with a designated amount of apples on each square");
            int[,] appleBoard = new int[4, 6] { { 1, 5, 8, 4, 9, 5 }, { 2, 11, 3, 8, 7, 9 }, { 22, 14, 89, 12, 5, 5 }, { 1, 5, 8, 4, 9, 8 } };
            Console.WriteLine("The board is as follows:");
            for (int i = 0; i < appleBoard.GetLength(0); i++)
            {
                for (int j = 0; j < appleBoard.GetLength(1); j++)
                {
                    Console.Write($"[{appleBoard[i, j]}] ");
                }
                Console.WriteLine();
            }

            int posX = 0;
            int posY = 0;
            string path = "";
            string pathFinal = "";
            int result = 0;
            int finalResult = 0;
            

            findApples(path, ref pathFinal, result, ref finalResult, appleBoard.GetLength(0), appleBoard.GetLength(1), appleBoard, posX, posY);

            Console.WriteLine($"The maximum amount of apples you can collect is: {finalResult}");
            Console.WriteLine($"The path you need to take to get {finalResult} apples is: {pathFinal}");
        }
    }
}
