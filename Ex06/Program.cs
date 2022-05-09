using Ex05.src;
using Ex06.src;

Console.WriteLine("Quantas listas de intervalos deseja adicionar?");
int quantidade = int.Parse(Console.ReadLine());

ListaIntervalo intervalos = new ListaIntervalo();

while (quantidade > 0)
{
    Console.WriteLine("Digite a data inicial: DD//MM/AAAA");
    DateTime dataInicial = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Digite a data final: DD//MM/AAAA");
    DateTime dataFinal = DateTime.Parse(Console.ReadLine());

    Intervalo intervalo = new Intervalo(dataInicial, dataFinal);
    
    intervalos.Adiciona(intervalo);

    quantidade--;

    if(quantidade <= 0)
    {
        intervalos.Imprime();
    }
}
