using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex05.src;

namespace Ex06.src
{
    internal class ListaIntervalo
    {
        private List<Intervalo> listaIntervalos;

        public List<Intervalo> ListaIntervalos { get { return listaIntervalos; }}

        public ListaIntervalo()
        {
            listaIntervalos = new List<Intervalo>();
        }

        public void Adiciona(Intervalo intervalo)
        {
            if (intervalo.TemIntersecao())
            {
                throw new Exception("Os intervalos não devem ter interseção");
            }

            listaIntervalos.Add(intervalo);
        }

        public void Imprime()
        {
            var lista = listaIntervalos.OrderBy(li => li.DataInicial).ToList();

            foreach(Intervalo intervalo in lista)
            {
                Console.WriteLine(intervalo.DataInicial.ToShortDateString());
            }
        }
    }
}
