using System;

namespace Exercicio016;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos cigarros foram fumados no dia?");
        int quantCigarros = int.Parse(Console.ReadLine());

        Console.WriteLine("Por quantos anos você fumou?");
        int quantAnos = int.Parse(Console.ReadLine());

        int quantCigarrosPorDia = quantCigarros * quantAnos * 365;
        int quantMinutosDeVida = quantCigarrosPorDia * 10;
        int quantMinutosEmHoras = quantMinutosDeVida / 60;
        int quantHorasEmDias = quantMinutosEmHoras / 24;

        Console.WriteLine($"O fumante perdera {quantHorasEmDias} dias de vida.");
    }
}
