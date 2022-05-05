using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.src
{
    internal class Vertice
    {
        public double x { get; private set; }
        public double y { get; private set; }

        public Vertice(double novoX, double novoY)
        {
            x = novoX;
            y = novoY;
        }

        public void Distancia()
        {
            double distanciaEuclidiana = Math.Sqrt(Math.Pow((x-y), 2));
            Console.WriteLine("\nDistancia euclidiana: {0}", distanciaEuclidiana);
        }

        public void Move()
        {
            Console.WriteLine("Digite o ponto x: ");
            double novoX = double.Parse(Console.ReadLine()); ;
            Console.WriteLine("Digite o ponto x: ");
            double novoY = double.Parse(Console.ReadLine()); ;

            x = novoX;
            y = novoY;

            Console.WriteLine("\nX: {0}, Y: {1}", novoX, novoY);
        }

        public void VerificaVertice()
        {
            if (x == y)
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
