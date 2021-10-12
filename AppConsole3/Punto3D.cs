using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsole3
{
    class Punto3D : Punto2D
    {
        protected double z;

        public double Z
        {
            get 
            {
                return z; 
            }
            set 
            { 
                z = value; 
            }
        }
         
        public Punto3D() : base()
        {
            z = 0;
        }
        public Punto3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }
        public override string ToString()
        {
            return base.ToString() + " Z=" + z;
        }
    }
}
