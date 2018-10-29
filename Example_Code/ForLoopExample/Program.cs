using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    //continue; izpuska sledvashtiq iteration na cikula. Za tova kogato ima chetno chislo to ne biva izpisano.
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
