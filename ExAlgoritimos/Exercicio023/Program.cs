namespace Exercicio023;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual seu nome: ");
        string nome = Console.ReadLine();

        string sexo;
        do
        {
            Console.WriteLine("Qual seu sexo: (F - feminino | M - masculino)");
            sexo = Console.ReadLine().ToUpper();

            if (sexo != "F" && sexo != "M")
                Console.WriteLine($"Valor {sexo} inválido");
        } while (sexo != "F" && sexo != "M");

        Console.WriteLine("Qual valor da compra: ");
        double valor = double.Parse(Console.ReadLine());

        while (valor <= 0)
        {
            Console.WriteLine($"Valor {valor:C} inválido");
            Console.WriteLine("Qual valor da compra: ");
            valor = double.Parse(Console.ReadLine());
        }

        double desconto = sexo == "F" ? valor * 0.13 : valor * 0.05;

        Console.WriteLine($"O valor da compra do(a) {nome} com desconto para {(sexo == "F" ? "mulher" : "homem")} é {valor - desconto:C}");
    }
}
