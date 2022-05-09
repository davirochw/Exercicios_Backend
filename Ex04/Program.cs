using Ex04.src;
using Ex02.src;

Console.WriteLine("Digite o X do 1º vértice:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o X do 2º vértice:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o X do 3º vértice:");
double x3 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o Y do 1º vértice:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o Y do 2º vértice:");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o Y do 3º vértice:");
double y3 = double.Parse(Console.ReadLine());

Poligono poligono = new Poligono(new Vertice(x1, y1), new Vertice(x2, y2), new Vertice(x3, y3));

Console.Write("Digite o número de vértices adicionados:");
int n = int.Parse(Console.ReadLine());


while (n > 0)
{
    Console.Write("Digite o valor do vértice:");
    double valor = double.Parse(Console.ReadLine());

    Vertice v = new Vertice(valor);
    poligono.AddVertice(v);
}

Console.Write("Deseja remover algum vértice? S/N");
char c = char.Parse(Console.ReadLine());

if (c == 'S' || c == 's')
{
    Console.Write("Digite o número de vértices que você quer remover:");
    n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Digite o índice do vértice que sera removido");
        poligono.QuantidadeVertices();

        Console.WriteLine();

        int index = int.Parse(Console.ReadLine());
        poligono.RemoveVertice(index);
    }
}

poligono.QuantidadeVertices();
Console.WriteLine("Perímetro:");
poligono.Perimetro();
