namespace Exercicio6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        double a = double.Parse(Console.ReadLine());

        double S = a * 2;

        double N = a / 3;

        Console.WriteLine("O dobro de " + a + " é igual a " + S);

        Console.WriteLine("A terça parte de " + a + " é igual a " + N);
    }
}
