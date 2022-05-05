using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07.src
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public long CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public float RendaMensal { get; set; }
        public char EstadoCivil { get; set; }
        public int Dependentes { get; set; }

        public Cliente(string nome, long cpf, DateTime dataNascimento, float rendaMensal, char estadoCivil, int dependentes)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            RendaMensal = rendaMensal;
            EstadoCivil = estadoCivil;
            Dependentes = dependentes;
        }

        public bool VerificaNome(string nome)
        {
            if (nome.Length < 5)
            {
                Console.WriteLine("O nome do cliente precisa ter pelo menos 5 caracteres");
                return false;
            }
            return true;
        }

        public bool VerificaCPF(string cpf)
        {
            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF inválido!");
                return false;
            }
            return true;
        }

        public bool VerificaDataNascimento(DateTime dataNascimento)
        {
            if (DateTime.Now.Year - dataNascimento.Year < 18)
            {
                Console.WriteLine("Cliente precisar ter mais de 18 anos!");
                return false;
            }
            return true;
        }

        public bool VerificaEstadoCivil(char estadoCivil)
        {
            if (estadoCivil != 'S' || estadoCivil != 'C' || estadoCivil != 'V' || estadoCivil != 'd' || estadoCivil != 's' || estadoCivil != 'c' || estadoCivil != 'v' || estadoCivil != 'd')
            {
                Console.WriteLine("Estado civil inválido!");
                return false;
            }
            return true;
        }
    }
}
