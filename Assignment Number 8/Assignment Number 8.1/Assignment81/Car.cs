using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment81
{
    abstract class Car : Vehicle
    {
        abstract public string Name { get; set; }
        public override void ListFeatures()
        {
            SteeringWheel();
            GasPedal();
            Brakes();
        }

        public override void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }

    class Ford : Car
    {
        public override string Name { get; set; }

        public Ford()
        {
            Name = "Ford Car.";
        }
    }
    
    class Acura : Car
    {
        public override string Name  { get; set; }

        public Acura()
        {
            Name = "Acura Car.";
        }

        public override void ListFeatures()
        {
            base.ListFeatures();
            GPS();
            CruiseControl();
        }

        public void GPS()
        {
            Console.WriteLine("Vehicle has GPS.");
        }

        public void CruiseControl()
        {
            Console.WriteLine("Vehicle has cruise control.");
        }

    }

}
