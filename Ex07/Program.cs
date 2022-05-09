using Ex07.src;

Console.Write("Quantos clientes deseja adicionar? ");
int n = int.Parse(Console.ReadLine());

Cliente cliente = new Cliente();

while (n > 0)
{
    Console.Write("Digite o nome do cliente: ");
    string nome = Console.ReadLine();

    if (cliente.VerificaNome(nome) == false)
    {
        continue;
    }

    Console.Write("Digite o CPF do cliente: ");
    long cpf = long.Parse(Console.ReadLine());

    Console.Write("Digite a data de nascimento do cliente: [DD/MM/YYYY]");
    DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

    if (cliente.VerificaDataNascimento(dataNascimento) == false)
    {
        break;
    }

    Console.Write("Digite a renda mensal do cliente: ");
    float rendaMensal = float.Parse(Console.ReadLine());

    Console.Write("Digite o estado civil do cliente: [S, C, V, D]");
    char estadoCivil = char.Parse(Console.ReadLine());

    if (cliente.VerificaEstadoCivil(estadoCivil) == true)
    {
        break;
    }

    Console.Write("Digite o número de dependentes do cliente: ");
    int dependentes = int.Parse(Console.ReadLine());

    if (cliente.VerificaDependentes(dependentes) == false)
    {
        break;
    }

    n--;

    Cliente cliente1 = new Cliente(nome, cpf, dataNascimento, rendaMensal, estadoCivil, dependentes);
    Console.WriteLine("Cliente adicionado com sucesso!");

    cliente1.InformacoesCliente();
}
