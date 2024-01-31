namespace Exercicio014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a quantidade de km percorrida pelo carro? ");
            int KmAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Por quantos dias o veiculo ficou alugado? ");
            int QuantDias = int.Parse(Console.ReadLine());

            double SomaDias = QuantDias * 90;
            double SomaKm = KmAtual * 0.20;
            double SomaKmeDias = SomaDias + SomaKm;

            Console.WriteLine($"O valor total a ser pago pelo aluguel do veiculo é de {SomaKmeDias.ToString("C")}");
        }
    }
}
