namespace Exercicio024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a distancia deseja percorrer em km: ");
            double distancia = double.Parse(Console.ReadLine());

            if (distancia <= 200)
            {
                double valorPorKm = distancia * 0.50;
                Console.WriteLine($"A distancia percorida é de {distancia} Km, e o valor da viagem é de {valorPorKm.ToString("C")}");
            }


        } 
    }
}
