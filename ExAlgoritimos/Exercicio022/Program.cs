namespace Exercicio022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu ano de nascimento? ");
            int nascimento = int.Parse(Console.ReadLine());

            int calculoIdade = DateTime.Now.Year - nascimento;
            int calculoAnos = Math.Abs(calculoIdade - 18);

            if (calculoIdade > 18)
                Console.WriteLine($"Você tem {calculoIdade} anos. Ja se passaram {calculoAnos} anos de alistamento militar.");
            else if (calculoIdade == 18)
                Console.WriteLine($"Você tem {calculoIdade} anos. Esta é a data limite para se alistar.");
            else
                Console.WriteLine($"Você tem {calculoIdade} anos. Falta {calculoAnos} anos para o alistamento militar.");
        }
    }
}
