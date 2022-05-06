using Ex02.src;

Console.WriteLine("Digite o primeiro ponto X: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o primeiro ponto Y: ");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo ponto X: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo ponto Y: ");
double y2 = double.Parse(Console.ReadLine());


Vertice vertice = new Vertice(x1, x2, y1, y2);

vertice.distancia();
vertice.verificaVertice(x1, x2, y1, y2);
vertice.move(x1, x2, y1, y2);
