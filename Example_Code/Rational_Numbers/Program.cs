using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber na = new RationalNumber(2,4);
            RationalNumber other = new RationalNumber(5,6);
            RationalNumber result = na * other;

            Console.WriteLine(result.Num);
            Console.WriteLine(result.Denom);
        }
    }
}
