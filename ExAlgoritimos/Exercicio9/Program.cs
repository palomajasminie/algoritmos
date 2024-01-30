using System.Globalization;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor em real: ");
            double a = double.Parse(Console.ReadLine());

            double us = a / 4.99;

            CultureInfo cultureInfoUS = new("en-US");

            Console.WriteLine($"O valor em real é igual a {a:C} e o valor em dolar é igual a {us.ToString("C", cultureInfoUS)}");


        }
    }
}
