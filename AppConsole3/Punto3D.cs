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
        public double Distancia(Punto3D pp)
        {
            double di = 0;
            double dx = x - pp.x;
            double dy = y - pp.y;
            double dz = z - pp.z;
            double cdx = Math.Pow(dx, 2);
            double cdy = Math.Pow(dy, 2);
            double cdz = Math.Pow(dz, 2);
            di = Math.Sqrt(cdx + cdy + cdz);
            return di;
        }
        public override string ToString()
        {
            return base.ToString() + " Z=" + z;
        }
    }
}

