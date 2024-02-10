namespace Exercicio020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            int somaNumeros = numero % 2;

            if (somaNumeros == 0)
            {
                Console.WriteLine($"O numero é par.");
            }
            else
            {
                Console.WriteLine($"O Numero é impar.");
            }
        }
    }
}
