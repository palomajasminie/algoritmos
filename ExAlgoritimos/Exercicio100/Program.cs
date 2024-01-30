using System;
using System.Data;

namespace ExercicioOpcional01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual valor do produto: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Será aumento ou desconto: (A - aumento | D - desconto)");
            string aumentoOuDesconto = Console.ReadLine();
            string tipo = (aumentoOuDesconto == "A" ? "aumento" : "desconto");

            Console.WriteLine($"Qual a porcentagem de {tipo} será aplicado no valor do produto: ");
            double porcento = double.Parse(Console.ReadLine());

            double valorDescontoOuAumento = valor * porcento / 100;
            double total = aumentoOuDesconto.Equals("A") ? valor + valorDescontoOuAumento : valor - valorDescontoOuAumento;

            Console.WriteLine($"O valor do produto com {tipo} de {porcento} é igual a {total:C}");
        }
    }
}
