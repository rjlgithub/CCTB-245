using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment81
{
    class Program
    {
        static void Main(string[] args)
        {
            Ford ford = new Ford();
            ford.DisplayName();
            ford.IsVehicle();
            ford.ListFeatures();

            Acura acura = new Acura();
            acura.DisplayName();
            acura.ListFeatures();

        }
    }
}
