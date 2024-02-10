namespace Exercicio017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a velocidade do veiculo? ");
            int velocidade = int.Parse(Console.ReadLine());

            int calculoMulta = velocidade - 80;
            int valorMulta = calculoMulta * 5;

            if ( velocidade > 80 ) 
            {

                Console.WriteLine($"Você foi multado, valor da multa é de {valorMulta.ToString("C")}");
            }
            else
            {
                Console.WriteLine("Você não foi multado");
            }

        }
    }
}
