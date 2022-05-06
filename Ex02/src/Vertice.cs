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

        public Vertice(double x1, double x2, double y1, double y2)
        {
            this.x = x1 - x2;
            this.y = y1 - y2;
        }

        public Vertice(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void distancia()
        {
            double distanciaEuclidiana = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            Console.WriteLine("\nDistancia euclidiana: {0}", distanciaEuclidiana);
        }

        public void move(double x1, double x2, double y1, double y2)
        {
            double auxiliarX = x1;
            double auxiliarY = y1;
            x1 = x2;
            x2 = auxiliarX;
            y1 = y2;
            y2 = auxiliarY;

            Console.WriteLine("\nPrimeiro X: {0}, Primeiro Y: {1}, Segundo X: {2}, Segundo Y: {3}", x1, y1, x2, y2);
        }

        public void verificaVertice(double x1, double x2, double y1, double y2)
        {
            if (x1.Equals(x2) && y1.Equals(y2))
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
