namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite um numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero: ");
            int b = int.Parse(Console.ReadLine());
                
                int S = a + b;

            Console.WriteLine("A soma de " + a + " e " + b + " é igual a " + S);
        }
    }
}
