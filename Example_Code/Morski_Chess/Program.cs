using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morski_Chess
{
    class Program
    {
        static void WriteBoard(int[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (board[i, j])
                    {
                        case 0:
                            Console.Write(" -- ");
                            break;
                        case 1:
                            Console.Write(" X ");
                            break;
                        case 2:
                            Console.Write(" O ");
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static bool GameOver (int[,] board)
        {

            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] != 0 && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
                if (board[i, 0] != 0 && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
            }
            if (board[1, 1] != 0 && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[1, 1] != 0 && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            // 0 - prazno mqsto, 1- X, 2 - O
            int[,] board = new int[3, 3];
            int currentPlayer = 1;
            WriteBoard(board);

            for (int i = 0; i < 9; i++)
            {
                
                Console.Write("Enter row number: ");
                int row = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter col number: ");
                int col = Convert.ToInt32(Console.ReadLine());
                board[row, col] = currentPlayer;

                if (GameOver(board) == true)
                {
                    Console.WriteLine($"Game Over! Player {currentPlayer} wins!");
                    break;
                }

                currentPlayer = (currentPlayer == 1) ? 2 : 1;

                WriteBoard(board);
            }
        }
    }
}
