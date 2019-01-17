using System;

namespace Matrix_From_File
{
    public static class Menu
    {
        public static void PrintMenu(string path,ref decimal[,] matrix)
        {
            bool doContinue = false;

            do
            {
                Console.Clear();

                MatrixReader.ReadMatrix(path,ref matrix);

                Console.WriteLine("1.PrintMatrix");
                Console.WriteLine("2.CheckIdentity");
                Console.WriteLine("3.SumNegativeOnAntiDiagonal");
                Console.WriteLine("4.NormalizeRows");
                Console.WriteLine("5.SortMatrix");
                Console.Write("Choose one: ");
                char operation = char.Parse(Console.ReadLine());

                switch (operation)
                {
                    case '1':
                        MatrixFunctions.PrintMatrix(matrix);
                        break;
                    case '2':
                        MatrixFunctions.CheckIdentity();
                        break;
                    case '3':
                        MatrixFunctions.SumNegativeOnAntiDiagonal();
                        break;
                    case '4':
                        MatrixFunctions.NormalizeRows();
                        break;
                    case '5':
                        MatrixFunctions.SortMatrix();
                        break;
                }



                Console.Write("Do you want to continue ? [y/n]");
                char op = char.Parse(Console.ReadLine());
                if (op == 'y') doContinue = true;
                else doContinue = false;
            }
            while (doContinue);

        }
    }
}
