using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.src
{
    internal class Intervalo
    {
        public DateTime dataInicial;
        public DateTime dataFinal;
        public TimeSpan duracao;

        public Intervalo(DateTime dataInicial, DateTime dataFinal)
        {
            if (dataInicial > dataFinal)
            {
                throw new Exception("A data inicial não pode ser maior que a data final");
            }

            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
            duracao = dataFinal - dataInicial;
        }

        public bool TemIntersecao(Intervalo outroIntervalo)
        {
            return (this.dataInicial <= outroIntervalo.dataFinal && this.dataFinal >= outroIntervalo.dataInicial);
        }

        public bool Igual(Intervalo outroIntervalo)
        {
            if (this.dataInicial == outroIntervalo.dataInicial && this.dataFinal == outroIntervalo.dataFinal)
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