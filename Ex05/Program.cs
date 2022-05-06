using Ex05.src;

Console.WriteLine("Digite a data inicial: DD//MM/AAAA");
DateTime dataInicial = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Digite a data final: DD//MM/AAAA");
DateTime dataFinal = DateTime.Parse(Console.ReadLine());
Intervalo intervalo1 = new Intervalo(dataInicial, dataFinal);

Console.WriteLine("Digite a data inicial: DD//MM/AAAA");
dataInicial = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Digite a data final: DD//MM/AAAA");
dataFinal = DateTime.Parse(Console.ReadLine());
Intervalo intervalo2 = new Intervalo(dataInicial, dataFinal);


Console.WriteLine();
intervalo1.TemIntersecao(intervalo2);
Console.WriteLine();
intervalo1.Igual(intervalo2);
