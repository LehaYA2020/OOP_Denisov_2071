using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_seminar
{
    class Rational
    {
        public int numerator;
        public int denumerator;
        public Rational(int numerator, int denumerator)
        {
            this.numerator = numerator;
            this.denumerator = denumerator;
        }
        public Rational Sum(Rational those)
        {
            Rational result = new Rational(0, 0);
            if (this.denumerator == those.denumerator)
            {
                result.numerator = this.numerator + those.numerator;
                result.denumerator = this.denumerator;
                
            }
            else
            {
                result.numerator = this.numerator * those.denumerator + those.numerator * this.denumerator;
                result.denumerator = this.denumerator * those.denumerator;
            }
            
            return Reduction(result);
        }
        public Rational Subtraction(Rational those)
        {
            Rational result = new Rational(0, 0);
            if (this.denumerator == those.denumerator)
            {
                result.numerator = this.numerator - those.numerator;
                result.denumerator = this.denumerator;
            }
            if (this.denumerator != those.denumerator)
            {
                result.numerator = this.numerator * those.denumerator - those.numerator * this.denumerator;
                result.denumerator = this.denumerator * those.denumerator;
            }
            return Reduction(result);
        }
        public Rational Multyply(Rational those)
        {
            Rational result = new Rational(those.numerator, those.denumerator);

            result.numerator = this.numerator * those.numerator;
            result.denumerator = this.denumerator * those.denumerator;

            return Reduction(result);
        }
        public Rational Division(Rational those)
        {
            Rational result = new Rational(those.numerator, those.denumerator);

            result.numerator = this.numerator * those.denumerator;
            result.denumerator = this.denumerator * those.numerator;

            return Reduction(result);
        }
        public Rational Reduction(Rational fraction)
        {
            int num = fraction.numerator;
            int denum = fraction.denumerator;
            int nod = NOD(num, denum);
                    fraction.numerator /=  nod;
                    fraction.denumerator /= nod;
            //Rational fraction_2 = new Rational(num, denum);
            return fraction;
        }
        public static Rational operator +(Rational x,Rational y)
        {

            return x.Sum(y);
        }
        public static Rational operator -(Rational x, Rational y)
        {

            return x.Subtraction(y);
        }
        public static Rational operator *(Rational x, Rational y)
        {

            return x.Multyply(y);
        }
        public static Rational operator /(Rational x, Rational y)
        {

            return x.Division(y);
        }
        public string FracToString(Rational fraction)
        {
            string res;
            if (fraction.denumerator == 1)
            {
                res = Convert.ToString(fraction.numerator);
            }
            else
            {
                res = Convert.ToString(fraction.numerator) + "/" + Convert.ToString(fraction.denumerator);
            }
            return res;
        }
        private int NOD(int m, int n)
        {
            int nod = 0;
            for (int i = 1; i < (n * m + 1); i++)
            {
                if (m % i == 0 && n % i == 0)
                {
                    nod = i;
                }
            }
            return nod;
        }
    }
}
