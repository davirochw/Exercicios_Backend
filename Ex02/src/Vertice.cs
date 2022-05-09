using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.src
{
    public class Vertice 
    {
        private double x;
        private double y;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public Vertice(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vertice(double x)
        {
            this.x = x;
        }

        public void Distancia()
        {
            double distanciaEuclidiana = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            Console.WriteLine("\nDistancia euclidiana: {0}", distanciaEuclidiana);
        }

        public void Move(double x, double y)
        {
            double auxiliarX = x;
            x = y;
            y = auxiliarX;

            Console.WriteLine("\nX: {0}, Y: {1}", x, y);
        }

        public void VerificaVertice(double x, double y)
        {
            if (x.Equals(y))
            {
                Console.WriteLine("\nOs vertices são iguais");
            }
            else
            {
                Console.WriteLine("\nOs vertices são diferentes");
            }
        }

    }
}
