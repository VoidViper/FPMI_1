using System;
using System.IO;

namespace Tochki_Zapetaiki_Chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doContinue = true;
            do
            {
                Console.Clear();
     
                Console.Write("Enter the path to the file: ");
                string path = Console.ReadLine();
                int dots = 0, commas = 0, numbers = 0;
                bool previousNumber = false, currentNumber;
                if (File.Exists(path))
                {
                    using (StreamReader myReader = new StreamReader(path))
                    {
                        while (myReader.Peek() >= -1)
                        {
                            //Console.WriteLine((char)myReader.Read()); test if the while loop works properly
                            if ((char)myReader.Read() == ',') commas++;
                            else if ((char)myReader.Read() == '.') dots++;
                            
                            //currentNumber = Char.IsNumber((char)myReader.Read());

                            //if ((previousNumber == true) && (currentNumber == false)) numbers++;
                            //previousNumber = currentNumber;
                            //currentNumber = false;
                        }
                        //if (previousNumber) numbers++;
                    }
                    Console.WriteLine($"{dots} dot(s).");
                    Console.WriteLine($"{commas} comma(s).");
                    //Console.WriteLine($"{numbers} number(s).");
                }
                else Console.WriteLine("You have enter an invalid path to the file.");


                Console.Write("Do you want to continue ? [y/n]: ");
                string decision = Console.ReadLine();
                if (decision == "n") doContinue = false;
                else if (decision == "y") doContinue = true;
                else Console.WriteLine("Invalid input. The program will continue");
            }
            while (doContinue);
        }
    }
}
