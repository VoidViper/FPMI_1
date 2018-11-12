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
            public double x, y;
            public void add(Point other)
            {
                x += other.x;
                y += other.y;
            }
        }
        static void PointInspector (Point point)
        {
            Console.WriteLine($"X: {point.x}\nY: {point.y}");
        }
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();

            p1.x = 2.3;
            p1.y = 5.3;

            p2.x = 1.2;
            p2.y = 4.5;

            PointInspector(p1);
            p1.add(p2);
            PointInspector(p1);
        }
    }
}
