using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavurshvane_AvgMark_MinchoEdition
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var sum = 0.00;
            var grades = 1;
            while (grades <= 12)
            {
                var marks = double.Parse(Console.ReadLine());
                sum += marks;
                if (marks >= 4)
                {
                    grades++;
                }
                if (marks < 4)
                {
                    marks = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} has been excluded at {1} grade", name, grades);
                    break;
                }
            }
            if (grades == 13)
            {
                Console.WriteLine("{0} graduated. Average grade: {1:f2}", name, (sum / 12));
            }
        }
    }
}
