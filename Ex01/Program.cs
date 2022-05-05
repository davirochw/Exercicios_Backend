using Ex01.src;

Console.WriteLine("Digite um valor: ");
int n = int.Parse(Console.ReadLine());

Piramide p = new Piramide(n);
p.desenha();
