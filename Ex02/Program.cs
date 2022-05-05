using Ex02.src;

Console.WriteLine("Digite o ponto X: ");
double x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ponto Y: ");
double y = int.Parse(Console.ReadLine());

Vertice vertice = new Vertice(x,y);

vertice.Distancia();
vertice.VerificaVertice();
vertice.Move();
