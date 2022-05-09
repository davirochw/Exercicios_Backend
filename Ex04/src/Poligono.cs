using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex02.src;

namespace Ex04.src
{
    internal class Poligono
    {
        private Vertice vertice1;
        private Vertice vertice2;
        private Vertice vertice3;

        public Vertice Vertice1 { get { return vertice1; } set { vertice1 = value; } }
        public Vertice Vertice2 { get { return vertice2; } set { vertice2 = value; } }
        public Vertice Vertice3 { get { return vertice3; } set { vertice3 = value; } }

        private List<Vertice> vertices;
        public List<Vertice> Vertices { get { return vertices; } }

        public Poligono(Vertice vertice1, Vertice vertice2, Vertice vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = vertice2;
            this.vertice3 = vertice3;

            if (vertice1 == null || vertice2 == null || vertice3 == null)
            {
                throw new ArgumentException("Um polígono deve ter 3 ou mais vértices");
            }

            vertices = new List<Vertice> { vertice1, vertice2, vertice3 };
        }

        public bool AddVertice(Vertice vertice)
        {
            Vertices.Add(vertice);
            return true;
        
        }

        public void RemoveVertice(int i)
        {
            if (Vertices.Count <= 3)
            {
                throw new Exception("Não pode ser mais removido, pois um polígono deve ter 3 ou mais vértices");
            }
            else
            {
                Vertices.RemoveAt(i);
            }
        }

        public double Perimetro()
        {
            double soma = 0;

            foreach(Vertice vertice in Vertices)
            {
                soma += vertice.X;
            }
            return soma;
        }

        public void QuantidadeVertices()
        {
            Console.WriteLine("O polígono têm {0} vertices", Vertices.Count);
        }

    }
}
