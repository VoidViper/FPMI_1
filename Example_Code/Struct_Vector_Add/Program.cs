using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Vector_Add
{
    class Program
    {
        struct Point
        {
            public double x;
            public double y;

            public Point(double x, double y)
            {
                Console.WriteLine("Yeeeeey!");
                this.x = x;
                this.y = y;
            }

            public void add(Point other)
            {
                x += other.x;
                y += other.y;
            }
        }

        static void PointInspector(Point point)
        {

            Console.WriteLine($"X: {point.x}\nY: {point.y}");

        }

        static void Main(string[] args)
        {
            Point p1 = new Point(1.2, 4.3);
            Point p2 = new Point(4.5, 6.4);

            PointInspector(p1);

            p1.add(p2);

            PointInspector(p1);

            Console.ReadLine();
        }
    }
}
