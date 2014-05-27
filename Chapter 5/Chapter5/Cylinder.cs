using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    public class Cylinder
    {
        #region Properties
        //Auto-implemented properties
        public double Radius { get; set; }
        public double Height { get; set; }
        //Regular property - getter only
        public double Volume
        {
            get
            {
                double result = Math.PI * Radius * Radius * Height;
                return result;
            }
        }
        #endregion

        #region Constructors
        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }
        #endregion

        #region Methods
        public static Cylinder operator +(Cylinder leftSide, Cylinder rightSide)
        {
            Cylinder result = new Cylinder(leftSide.Radius, (leftSide.Height + rightSide.Height));
            return result;
        }
        #endregion
    }
}
