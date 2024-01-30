namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual valor do produto ?");
            double valor = double.Parse(Console.ReadLine());

            double desconto = valor * 5 / 100 ;
            double total = valor - desconto;  


            Console.WriteLine($"O valor do produto com desconto de 5% é igual a {total.ToString("C")}");
        }
    }
}
