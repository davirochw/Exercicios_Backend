using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.src
{
    public class Intervalo
    {
        private DateTime dataInicial;
        private DateTime dataFinal;
        public DateTime DataInicial { get { return dataInicial; } set { dataInicial = value; } }
        public DateTime DataFinal { get { return dataFinal; } set { dataFinal = value; } }
        public TimeSpan duracao { get { return dataFinal - dataInicial; } }

        public Intervalo(DateTime dataInicial, DateTime dataFinal)
        {
            if (dataInicial > dataFinal)
            {
                throw new Exception("A data inicial não pode ser maior que a data final");
            }

            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;

            Console.WriteLine("\nA duração é: {0} dia(s)\n", duracao.Days);
        }

        public bool TemIntersecao()
        {
            return (this.dataInicial.Equals(this.dataFinal));
        }

        public bool Igual()
        {
            if (this.dataInicial.Equals(this.dataFinal))
            {
                Console.WriteLine("Intervalos iguais");
                return true;
            }
            else
            {
                Console.WriteLine("Intervalos diferentes");
                return false;
            }
        }
    }
}