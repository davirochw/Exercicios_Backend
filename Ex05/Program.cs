using Ex05.src;

Console.WriteLine("Digite a data inicial: DD//MM/AAAA");
DateTime dataInicial = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Digite a data final: DD//MM/AAAA");
DateTime dataFinal = DateTime.Parse(Console.ReadLine());
Intervalo intervalo = new Intervalo(dataInicial, dataFinal);

Console.WriteLine();
intervalo.TemIntersecao();
Console.WriteLine();
intervalo.Igual();
