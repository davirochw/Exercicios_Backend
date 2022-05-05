using Ex07.src;

Console.Write("Quantos clientes deseja adicionar? ");
int n = int.Parse(Console.ReadLine());

while (n > 0)
{
    Console.Write("Digite o nome do cliente: ");
    string nome = Console.ReadLine();
    Console.Write("Digite o CPF do cliente: ");
    long cpf = long.Parse(Console.ReadLine());
    Console.Write("Digite a data de nascimento do cliente: ");
    DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
    Console.Write("Digite a renda mensal do cliente: ");
    float rendaMensal = float.Parse(Console.ReadLine());
    Console.Write("Digite o estado civil do cliente: ");
    char estadoCivil = char.Parse(Console.ReadLine());
    Console.Write("Digite o número de dependentes do cliente: ");
    int dependentes = int.Parse(Console.ReadLine());
    n--;

    Cliente cliente = new Cliente(nome, cpf, dataNascimento, rendaMensal, estadoCivil, dependentes);
    Console.WriteLine("Cliente adicionado com sucesso!");
    Console.WriteLine();
}