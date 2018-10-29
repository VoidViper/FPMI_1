using System;

namespace Kvadratno_Uravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D, x1, x2;

            Console.WriteLine("Dobre doshli v programa za reshavane na kvadratno uravnenie!");

            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToDouble(Console.ReadLine());

            D = Math.Pow(b, 2) - 4 * a * c;
            Console.Write("D=");
            Console.WriteLine(D);

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;

                Console.Write("x1=");
                Console.WriteLine(x1);

                Console.Write("x2=");
                Console.WriteLine(x2);
            }
            else if (D == 0)
            {
                x1 = (-b) / 2 * a;

                Console.Write("x1=x2=");
                Console.Write(x1);
            }
            else Console.WriteLine("Nqma Realni Koreni. Opitai s kompleksni chisla.");


            Console.ReadLine();
        }
    }
}
