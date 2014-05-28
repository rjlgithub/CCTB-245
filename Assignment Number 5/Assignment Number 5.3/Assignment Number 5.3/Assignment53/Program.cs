using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment53
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 230;
            int a2 = 5;
            int s1 = 55;
            int s2 = 7;

            int aCalc = KCalculator.Add(a1, a2);
            int sCalc = KCalculator.Subtract(s1, s2);

            Console.WriteLine();
            Console.WriteLine("{0} + {1} = {2} ", KCalculator.times1000(a1), KCalculator.times1000(a2), aCalc);
            Console.WriteLine(" {0} - {1} =  {2} ", KCalculator.times1000(s1), KCalculator.times1000(s2), sCalc);
        }
    }
}
