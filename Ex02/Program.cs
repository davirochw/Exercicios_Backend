using Ex02.src;

Console.WriteLine("Digite o ponto X: ");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o ponto Y: ");
double y = double.Parse(Console.ReadLine());

Vertice vertice = new Vertice(x, y);

vertice.Distancia();
vertice.VerificaVertice(x, y);
vertice.Move(x, y);
