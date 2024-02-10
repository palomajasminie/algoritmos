namespace Exercicio018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu ano de nascimento? ");
            int nascimento = int.Parse(Console.ReadLine());

            int calculoIdade = 2024 - nascimento;

            if (calculoIdade > 18)

            {
                Console.WriteLine($"Sua idade é de {calculoIdade} anos. Você ja pode votar.");
            }
            else
            {
                Console.WriteLine($"Sua idade é de {calculoIdade} anos. Você ainda não pode votar.");
            }

        }
    }
}
