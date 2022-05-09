using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex02.src;

namespace Ex03.src
{
    public enum TipoTriangulo { Equilatero, Isosceles, Escaleno };
    internal class Triangulo
    {
        private double perimetro;
        private double ladoA;
        private double ladoB;
        private double ladoC;

        private Vertice vertice1;
        private Vertice vertice2;
        private Vertice vertice3;

        public double LadoA { get { return ladoA; } set { ladoA = value; } }
        public double LadoB { get { return ladoB; } set { ladoB = value; } }
        public double LadoC { get { return ladoC; } set { ladoC = value; } }

        public Vertice Vertice1 { get { return vertice1; } set { vertice1 = value; } }
        public Vertice Vertice2 { get { return vertice2; } set { vertice2 = value; } }
        public Vertice Vertice3 { get { return vertice3; } set { vertice3 = value; } }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;

            if (ladoA == 0 && ladoA == 0 && ladoC == 0)
            {
                throw new Exception("Isso não é um triangulo");
            }

            vertice1 = new Vertice(ladoA, ladoB);
            vertice2 = new Vertice(ladoB, ladoC);
            vertice3 = new Vertice(ladoC, ladoA);

            vertice1.Distancia();
            vertice2.Distancia();
            vertice3.Distancia();
        }

        public void Perimetro()
        {
            this.perimetro = (ladoA + ladoB + ladoC);
            Console.WriteLine("\nPerimetro: {0}", this.perimetro);
        }

        public TipoTriangulo Tipo()
        {
            if (ladoA.Equals(ladoB) && ladoB.Equals(ladoC))
            {
                Console.WriteLine("\nTipo: {0}", TipoTriangulo.Equilatero);
                return TipoTriangulo.Equilatero;
            }
            else if (ladoA != ladoB && ladoB != ladoC)
            {
                Console.WriteLine("\nTipo: {0}", TipoTriangulo.Escaleno);
                return TipoTriangulo.Escaleno;
            }
            else
            {
                Console.WriteLine("\nTipo: {0}", TipoTriangulo.Isosceles);
                return TipoTriangulo.Isosceles;
            }
        }

        public void Area()
        {
            var x = this.perimetro / 2;
            double area = Math.Abs(x * (x - ladoA) * (x - ladoB) * (x - ladoC));

            Console.WriteLine("\nArea: {0}", area);
        }
    }
}
