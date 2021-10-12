﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsole3
{
    class Punto
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
        public override string ToString()
        {
            return "X="+ x;
        }

    }
}
