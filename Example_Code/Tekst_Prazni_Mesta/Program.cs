using System;


namespace Tekst_Prazni_Mesta
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun, adj, verb;
            // example noun = dog
            // example adj = fast
            // example verb = decide
            string pt1, pt2, pt3;
            Console.Write("Please enter a noun:");
            noun = Console.ReadLine();

            Console.Write("Please enter an adjective:");
            adj = Console.ReadLine();

            Console.Write("Please enter a verb:");
            verb = Console.ReadLine();

            pt1 = "Have you ever stopped to watch a ";
            pt2 = " from a tree, and take to the air? Me neither. Have you ever took time out to finish a rhyme but the ";
            pt3 = " words just weren't there? Meat cleaver.";

            Console.Write(pt1 + noun);
            Console.Write(pt2 + verb);
            Console.Write(" " + adj);
            Console.Write(pt3);

            Console.ReadLine();
        }
    }
}
