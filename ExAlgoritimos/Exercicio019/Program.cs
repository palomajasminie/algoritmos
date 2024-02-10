using System;

namespace Exercicio019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome? ");
            string nome =  (Console.ReadLine());

            Console.WriteLine("Qual a nota da primeira prova? ");
            int primeiraProva = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota da segunda prova? ");
            int segundaProva = int.Parse(Console.ReadLine());

            int somaNotas = (primeiraProva + segundaProva) / 2;

            if (somaNotas >= 7) 
            {
                Console.WriteLine($"Sua media é de {somaNotas} e seu aproveitamento foi bom.");
            }
            else
            {
                Console.WriteLine($"Sua media é de {somaNotas} e seu aproveitamento foi ruim.");
            }

        }
    }
}