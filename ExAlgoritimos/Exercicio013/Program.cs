namespace Exercicio013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu salario? ");
            double valor = double.Parse(Console.ReadLine());

            double aumento = valor * 15 / 100;
            double total = valor + aumento;

            Console.WriteLine($"O valor do salario com aumento de 15% é igual {total.ToString("C")}");
        }
    }
}
