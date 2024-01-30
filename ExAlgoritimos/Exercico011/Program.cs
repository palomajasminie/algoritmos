namespace Exercico011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite valor de a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor de c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine($"O valor de delta é igual a {delta}");
        }
    }
}
