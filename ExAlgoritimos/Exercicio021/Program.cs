namespace Exercicio021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            int somaAno = ano % 4;

            if (somaAno == 0)
            {
                Console.WriteLine($"O ano é bissexto.");
            }
            else
            {
                Console.WriteLine($"O ano é bissexto");
            }
        }
    }
}
