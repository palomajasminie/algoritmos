namespace Exercicio015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos dias o funcionrio trabalhou no mês");
            int DiasTrab = int.Parse(Console.ReadLine());

            int ValoreDias = DiasTrab * (25 * 8);

            Console.WriteLine($"O funcionario trabalhou {DiasTrab} então seu salario é igual a {ValoreDias.ToString("C")}");
        }
    }
}
