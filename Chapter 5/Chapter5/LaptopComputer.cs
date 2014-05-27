using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    //Class LaptopComputer inherits from Class Computer
    public class LaptopComputer : Computer
    {
        public double MonitorSize { get; set; }

        public override void Purchase()
        {
            Console.Write("A " + MonitorSize + " laptop ");
            base.Purchase();
        }

    }
}
