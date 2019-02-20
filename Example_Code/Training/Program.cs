using System;

namespace Training
{
    class Program
    {
        //print out the censored sentence
        static int Censorship(string sentence,string word)
        {
            string[] buffer = sentence.Split(' '); //идеята на тоя масив е да държи думите от изречението една по една без интервали

            string newWord = new string('*', word.Length); //тук правим дума, която е със същия брой символи като думата, която сме приели обаче е само *
            int counter = 0; //obviously брояча, който ще върнем

            for (int i = 0; i < buffer.Length; i++) // for loop, който обхожда всеки един елемент от масива buffer, който ни държи думите от изречението
            {
                if (buffer[i] == word) //проверяваме дали всяка дума от изречението съвпада с думата, която сме приели от потребителя
                {
                    buffer[i] = newWord; //присвояваме думата със звездички на мястото на елемент-а, който съвпада с думата от потребителя
                    counter++; //self-explanatory
                }
            }
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i] + " ");
            }
            Console.WriteLine();

            return counter;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine(Censorship(sentence,word));
        }
    }
}
