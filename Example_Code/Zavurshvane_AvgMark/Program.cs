using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavurshvane_AvgMark
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = Console.ReadLine();
            int currGrade = 1;
            double currSum = 0.0;
            int hasFailed = 0;

            while (true)
            {
                double currMark;
                currMark = Convert.ToDouble(Console.ReadLine());
                if (currMark >= 4)
                {
                    currSum += currMark;
                    currGrade++;
                }
                else
                {
                    if (hasFailed == 1)
                    {
                        hasFailed = 2;
                        Console.Write($"{name} has been excluded at {currGrade}");
                        break;
                    }
                    else
                    {
                        hasFailed = 1;
                    }
                }
                if (hasFailed == 2)
                    break;
                if (currGrade == 13)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {(currSum / 12):f2}");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
