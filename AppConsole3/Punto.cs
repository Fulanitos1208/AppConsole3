using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsole3
{
    class Punto
    {
            {
        protected double x;

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public Punto()
        {
            x = 0;
        }
        public Punto(double x)
        {
            this.x = x;
        }
        public double Distancia(Punto p)
        {
            double d = 0;
            d = x - p.x;
            d = Math.Abs(d);
            return d;
        }
        public override string ToString()
        {
            return "X="+ x;
        }

    }
}
