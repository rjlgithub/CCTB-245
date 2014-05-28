using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment52
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction oneHalf = new Fraction(1, 2);
            Fraction oneQuarter = new Fraction(1, 4);

            Fraction overLoadedFraction = oneHalf + oneQuarter;

            Console.WriteLine("{0} + {1} = {2}", oneHalf.ToString(), oneQuarter.ToString(), overLoadedFraction.ToString());
        }
    }
}
