using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aylinka123
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[16];
            double sum = 0, avg = 0;
            int belowAvg = 0, counter = 0, aboveAvg = 0;

            for (int i = 0; i < 16; i++)
            {
                scores[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 16; i++)
            {
                sum += scores[i];
            }
            avg = sum / 16;

            for (int i = 0; i < 16; i++)
            {
                if (scores[i] <= avg)
                {
                    belowAvg++;
                }
                else aboveAvg++;
            }            

            Console.WriteLine($"Average: {avg}");
            Console.WriteLine($"Below Average: {belowAvg} scores");
            Console.WriteLine($"Avobe Average: {aboveAvg} scores");



        }
    }
}
