#nullable disable
namespace AP;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Deseja utilizar a calculadora? (s/n)");
        string calculo = Console.ReadLine();

        while (calculo == "s")
        {
            if (calculo == "n")
            {
                break;
            }

            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            double n3 = double.Parse(Console.ReadLine());

            double resultadosoma = n1 + n2 + n3;
            double resultadomultiplicacao = n1 * n2 * n3;
            double resultadodivisao = (n1 / n2) / n3;
            double resultadosubtracao = (n1 - n2) - n3;

            Console.WriteLine($"O resultado da soma destes dois números é: {resultadosoma}");
            Console.WriteLine($"O resultado da multiplicação destes dois números é: {resultadomultiplicacao}");
            Console.WriteLine($"O resultado da divisão destes dois números é: {resultadodivisao}");
            Console.WriteLine($"O resultado da subtração destes dois números é: {resultadosubtracao}");
            
            Console.WriteLine("Deseja continuar utilizando a calculadora? (s/n)");
            calculo = Console.ReadLine();

        }
    }
}