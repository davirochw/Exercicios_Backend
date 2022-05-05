using Ex05.src;

Console.WriteLine("Digite a data inicial: ");
DateTime dataInicial = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Digite a data final: ");
DateTime dataFinal = DateTime.Parse(Console.ReadLine());
Intervalo intervalo1 = new Intervalo(dataInicial, dataFinal);

Console.WriteLine("Digite a data inicial: ");
dataInicial = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Digite a data final: ");
dataFinal = DateTime.Parse(Console.ReadLine());
Intervalo intervalo2 = new Intervalo(dataInicial, dataFinal);


Console.WriteLine();
intervalo1.TemIntersecao(intervalo2);
Console.WriteLine();
intervalo1.Igual(intervalo2);
