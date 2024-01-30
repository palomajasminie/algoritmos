namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma distancia em metros: ");
            double a = double.Parse(Console.ReadLine());

            double km = a / 1000;

            double hm = a / 100;

            double dam = a / 10;

            double dm = a * 10;

            double cm = a * 100;

            double mm = a * 1000;

            Console.WriteLine("em quilometros essa distancie é igual a " + km);

            Console.WriteLine("em hm = " + hm);

            Console.WriteLine("em dam = " +dam);

            Console.WriteLine("em dm = " + dm);

            Console.WriteLine("em cm = " + cm);

            Console.WriteLine("em mm = " + mm.ToString("N1").Replace(".", ""));

        }
    }
}
