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
                char[] buffer = new char[1];
                bool currentPos, prevPos = false;
                if (File.Exists(path))
                {
                    using (StreamReader myReader = new StreamReader(path))
                    {
                        while (myReader.Peek() > -1)
                        {
                            myReader.Read(buffer, 0, 1);

                            if (buffer[0] == '.') dots++;
                            if (buffer[0] == ',') commas++;

                            currentPos = Char.IsNumber(buffer[0]);
                            if ((prevPos == true) && (currentPos == false)) numbers++;
                            prevPos = currentPos;
                            currentPos = false;
                        }
                        if (prevPos) numbers++;
                    }
                    Console.WriteLine($"{dots} dot(s).");
                    Console.WriteLine($"{commas} comma(s).");
                    Console.WriteLine($"{numbers} number(s)");
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
