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
            Rational result=new Rational(those.numerator,those.denumerator);
            if (this.denumerator == those.denumerator)
            {
                result.numerator = this.numerator + those.numerator;
                result.denumerator = this.denumerator;
            }
            if(this.denumerator != those.denumerator)
            {
                result.numerator = this.numerator*those.denumerator + those.numerator * this.denumerator;
                result.denumerator = this.denumerator*those.denumerator;
            }
            return result;
        } 
    }
}
