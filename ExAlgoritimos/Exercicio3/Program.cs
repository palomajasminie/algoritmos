namespace Exercicio3;

class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Digite seu salario: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Olá " + nome + " seja bem vinda! Seu salario é de " + saldo.ToString("C"));
        }
    }
}
