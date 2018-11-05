using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cows_and_Bulls
{
    class Program
    {
        static void Main(string[] args)
        {
            //cows = dadeana cifra sushtestvuva v chisloto
            //bulls = dadenata cifra sushtestvuva i e na pravilnoto mqsto
            string numToGuess, guess;
            int bulls, cows;
            bool invalidNumber = false;
            do
            {
                Console.Write("Enter a number to be guessed: ");
                numToGuess = Console.ReadLine();
                invalidNumber = false;

                for (int i = 0; i < numToGuess.Length; i++)
                {
                    for (int j = i + 1; j < numToGuess.Length; j++)
                    {
                        if (numToGuess[i] == numToGuess[j])
                        {
                            Console.WriteLine("The number cannot have duplicate digits.");
                            invalidNumber = true;
                            break;
                        }
                    }
                    if (invalidNumber) break;
                }
            }
            while (invalidNumber == true);
            Console.Clear();
            do
            {
                bulls = 0;
                cows = 0;
                Console.Write("Enter your guess: ");
                guess = Console.ReadLine();
                if(guess.Length<= numToGuess.Length)
                {
                    for (int i = 0; i < numToGuess.Length; i++)
                    {
                        for (int j = 0; j < guess.Length; j++)
                        {
                            if ((numToGuess[i] == guess[j]) && (i == j))
                            {
                                bulls++;
                            }
                            else if (numToGuess[i] == guess[j])
                            {
                                cows++;
                            }
                        }
                    }
                    Console.WriteLine($"{bulls} bulls");
                    Console.WriteLine($"{cows} cows");
                }
                else
                {
                    Console.WriteLine("The number you have entered is longer than the number to be guessed");
                }
            }
            while (bulls != numToGuess.Length);
        }
    }
}
