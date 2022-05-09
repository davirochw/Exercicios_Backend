using Ex03.src;
using Ex02.src;

Console.WriteLine("Digite o lado A do Triangulo");
double ladoA = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado B do Triangulo");
double ladoB = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado C do Triangulo");
double ladoC = double.Parse(Console.ReadLine());

Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

triangulo.Perimetro();
triangulo.Tipo();
triangulo.Area();