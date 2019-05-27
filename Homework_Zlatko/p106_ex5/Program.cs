using System;
//Homework by Georgi Gogov
//Page 106 / ex.5

namespace p106_ex5
{
    struct RWB
    {
        public int Red;
        public int Blue;
        public int White;
    }
    class Program
    {
        public static string Examine(string[] matrix, int index)
        {
            return matrix[index];
        }

        public static void SwapColors(ref string[] matrix, int posA, int posB)
        {
            string temp = matrix[posA];
            matrix[posA] = matrix[posB];
            matrix[posB] = temp;
        }

        static void Main(string[] args)
        {
            RWB qweqwe = new RWB();
            Console.Write("Enter how many colors you want to be sorted: ");
            int amount = int.Parse(Console.ReadLine());
            string[] strArr = new string[amount];
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.Write($"Enter R/W/B for position [{i}]: ");
                strArr[i] = Console.ReadLine();
            }

            qweqwe.Red = 0;
            qweqwe.Blue = 0;
            qweqwe.White = strArr.Length - 1;

            while (qweqwe.Blue <= qweqwe.White)
            {
                if (Examine(strArr, qweqwe.Blue) == "R")
                    SwapColors(ref strArr, qweqwe.Red++, qweqwe.Blue++);
                else if (Examine(strArr, qweqwe.Blue) == "W")
                    SwapColors(ref strArr, qweqwe.Blue, qweqwe.White--);
                else if (Examine(strArr, qweqwe.Blue) == "B")
                    qweqwe.Blue++;
            }

            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
            }
        }
    }
}
