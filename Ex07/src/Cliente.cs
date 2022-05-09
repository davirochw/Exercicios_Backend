using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07.src
{
    internal class Cliente
    {
        public string nome { get; set; }
        public long cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public float rendaMensal { get; set; }
        public char estadoCivil { get; set; }
        public int dependentes { get; set; }

        public Cliente(string nome, long cpf, DateTime dataNascimento, float rendaMensal, char estadoCivil, int dependentes)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.rendaMensal = rendaMensal;
            this.estadoCivil = estadoCivil;
            this.dependentes = dependentes;
        }

        public Cliente() { 
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
            if (estadoCivil != 'S' || estadoCivil != 'C' || estadoCivil != 'V' || estadoCivil != 'D' || estadoCivil != 's' || estadoCivil != 'c' || estadoCivil != 'v' || estadoCivil != 'd')
            {
                return false;
            } else
            {
                Console.WriteLine("Estado civil inválido!");
                return true;
            }
        }

        public bool VerificaDependentes(int dependentes)
        {
            if (dependentes >= 0 && dependentes <= 10)
            {
                return true;
            }
            return false;
        }

        public void InformacoesCliente()
        {
            Console.WriteLine("--- CLIENTE ---" +
                "\nNome: {0}" +
                "\nCPF: {1}" +
                "\nData de Nascimento: {2}" +
                "\nRenda Mensal: {3}" +
                "\nEstado Civil: {4}" +
                "\nDependentes: {5}", nome, cpf, dataNascimento.ToShortDateString, rendaMensal, estadoCivil, dependentes);
        }
    }
}
