using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment53
{
    public static class KCalculator
    {
        static public int Add(int value1, int value2)
        {
            return 1000 * (value1 + value2);
        }
        
        static public int Subtract(int value1, int value2)
        {
            return 1000 * (value1 - value2);
        }

        static public int times1000(int value1)
        {
            return 1000 * value1;
        }
 
    }
}
