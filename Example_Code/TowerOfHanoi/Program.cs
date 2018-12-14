using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
        static void MoveDisks(int disks, string startSpike, string endSpike, string helpSpike)
        {
            if (disks == 1)
                Console.WriteLine($"Move from {startSpike} to {endSpike}");
            else
            {
                MoveDisks(disks - 1, startSpike, helpSpike, endSpike);
                MoveDisks(1, startSpike, endSpike, helpSpike);
                MoveDisks(disks - 1, helpSpike, endSpike, startSpike);
            }
        }
        static void HanoiSolver(int disks)
        {
            MoveDisks(disks, "Left", "Right", "Middle");
        }
        static void Main(string[] args)
        {
            Console.Write("Number of disks: ");
            int n = int.Parse(Console.ReadLine());
            HanoiSolver(n);
        }
    }
}
