using System;
namespace Posledna_Lekciq
{
    public class Menu
    {
        public static void PrintMenu()
        {
            bool doContinue = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Current 2D array");
                ArrayIO.+PrintArray();
                Console.WriteLine("This program will let you do the following things:");
                Console.WriteLine("1.Add a new 2D array");
                Console.WriteLine("2.Print the 2D array");
                Console.WriteLine("3.Save the 2D array to a file");
                Console.WriteLine("4.Read a 2D array from a file");
                Console.WriteLine("5.Insertion sort of the elements in the 2D array");
                Console.WriteLine("6.Bubble sort the elements in the 2D array");
                Console.WriteLine("7.Selection sort the elements in the 2D array");
                Console.Write("What operation would you like to perform? [Choose from 1 to 7]: ");
                var operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        ArrayIO.AddNewArray();
                        break;
                    case 2:
                        ArrayIO.PrintArray();
                        break;
                    case 3:
                        ArrayIO.SaveArrayToFile();
                        break;
                    case 4:
                        ArrayIO.ReadArray();
                        break;
                    case 5:
                        Functions.InsertionSort();
                        break;
                    case 6:
                        Functions.BubbleSort();
                        break;
                    case 7:
                        Functions.SelectionSort();
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
