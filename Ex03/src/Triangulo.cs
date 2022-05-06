using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex02.src;

namespace Ex03.src
{
    internal class Triangulo
    {
        private double x;
        private double y;

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
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Triangulo(double x, double y)
        {
            Vertice vertice = new Vertice(x, y);
        }

    }
}
