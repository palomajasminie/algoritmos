namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double a = double.Parse(Console.ReadLine());

            double S = a + 1;

            double N = a - 1;

            Console.WriteLine("O antecessor desse numero é igual a " + N);

            Console.WriteLine("O sucecessor desse numero é igual a " + S);
        }
    }
}
