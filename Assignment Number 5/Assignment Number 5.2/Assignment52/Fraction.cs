using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment52
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction p1, Fraction p2)
        {
            Fraction newFraction = new Fraction(p1.Numerator, p1.Denominator);
            newFraction.Numerator = newFraction.Numerator * p2.Denominator + p2.Numerator * newFraction.Denominator;
            newFraction.Denominator = newFraction.Denominator * p2.Denominator;

            return newFraction;
        }

        public override string ToString()
        {
            return Numerator.ToString() + "/" + Denominator.ToString();
        }
    }
}
