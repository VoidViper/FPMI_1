using System;
using System.IO;

namespace Posledna_Lekciq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (!File.Exists("buffer.txt"))
            {
                File.Create("buffer.txt");
            }
            else
            {
                File.Open("buffer.txt", FileMode.Open, FileAccess.ReadWrite);
                Menu.PrintMenu();
            }

        }
    }
    }
}
