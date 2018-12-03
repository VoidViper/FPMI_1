using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational_Numbers
{
    class RationalNumber
    {
        public int Num
        {
            get;
            set;
        }
        public int Denom
        {
            get;
            set;
        }
        public static RationalNumber operator * (RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.Num * b.Num, a.Denom * b.Denom);
        }
        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            int nok = a.Denom * b.Denom;

            return new RationalNumber(a.Num * b.Num, a.Denom * b.Denom);
        }
        public RationalNumber (int num, int denom)
        {
            this.Num = num;
            this.Denom = denom;
        }
        public RationalNumber()
        {
            
        }

    }
}
