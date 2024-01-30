namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Digite a altura da parede: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura da parede: ");
            double l = double.Parse(Console.ReadLine());

            double area = a * l;
            double tinta = (area / 2);

            Console.WriteLine($"A area da parede a ser pintada é igual a {area} metros e a a quantidade de tinta a ser usada é de {tinta} litros");
        }
    }
}
