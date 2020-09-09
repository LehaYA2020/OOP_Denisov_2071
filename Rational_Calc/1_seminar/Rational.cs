﻿using System;
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
            Rational result = new Rational(those.numerator, those.denumerator);
            if (this.denumerator == those.denumerator)
            {
                result.numerator = this.numerator + those.numerator;
                result.denumerator = this.denumerator;
            }
            if (this.denumerator != those.denumerator)
            {
                result.numerator = this.numerator * those.denumerator + those.numerator * this.denumerator;
                result.denumerator = this.denumerator * those.denumerator;
            }
            return result;
        }
        public Rational Subtraction(Rational those)
        {
            Rational result = new Rational(those.numerator, those.denumerator);
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
            return result;
        }
        public Rational Multyply(Rational those)
        {
            Rational result = new Rational(those.numerator, those.denumerator);

            result.numerator = this.numerator * those.numerator;
            result.denumerator = this.denumerator * those.denumerator;

            return result;
        }
        public Rational Division(Rational those)
        {
            Rational result = new Rational(those.numerator, those.denumerator);

            result.numerator = this.numerator / those.numerator;
            result.denumerator = this.denumerator / those.denumerator;

            return result;
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
    }
}