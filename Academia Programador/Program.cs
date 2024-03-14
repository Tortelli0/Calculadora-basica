#nullable disable
using System.Net;
using System.Net.Sockets;

namespace Calculadora;
//Eduardo Tortelli

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo a Calculadora!");
        Console.WriteLine("Deseja começar uma operação? (s/n)");
        string calculo = Console.ReadLine();

        if (calculo == "n")
        {
            Console.WriteLine("\nCaso queira continuar o programa digite S.");
            calculo = Console.ReadLine();
        }

        while( calculo != "s")
        {
            Console.WriteLine("\nOpção inválida, digite novamente.");
            Console.WriteLine("Deseja começar uma operação? (s/n)");
            calculo = Console.ReadLine();
        }

        Console.WriteLine("\nDigite 1 para realizar todas as operações e 2 para escolher a operação: ");
        int opçoes = int.Parse(Console.ReadLine());

        if (opçoes == 1)
        {
            while (calculo == "s")
            {
                if (calculo == "n")
                {
                    break;
                }

                Console.WriteLine("\nDigite o primeiro número: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite o segundo número: ");
                double n2 = double.Parse(Console.ReadLine());

                while (n2 == 0)
                {
                    Console.WriteLine("\nO segundo número não poder ser zero, digite novamente.");

                    Console.WriteLine("\nDigite o segundo número novamente: ");

                    n2 = double.Parse(Console.ReadLine());
                    break;
                }

                double resultadosoma = n1 + n2;
                double resultadomultiplicacao = n1 * n2;
                double resultadodivisao = n1 / n2;
                double resultadosubtracao = n1 - n2;

                Console.WriteLine($"\nO resultado da soma destes dois números é: {resultadosoma}");
                Console.WriteLine($"\nO resultado da multiplicação destes dois números é: {resultadomultiplicacao}");
                Console.WriteLine($"\nO resultado da divisão destes dois números é: {resultadodivisao}");
                Console.WriteLine($"\nO resultado da subtração destes dois números é: {resultadosubtracao}");
                Console.WriteLine("\nDeseja continuar utilizando a calculadora? (s/n)");
                calculo = Console.ReadLine();
                break;

            }
        }

            if  (opçoes == 2 )
            {
                while (calculo == "s")
                {
                    if (calculo == "n")
                    {
                        break;
                    }

                    Console.WriteLine("\nDigite 1 para Adicionar");
                    Console.WriteLine("Digite 2 para Subtrair");
                    Console.WriteLine("Digite 3 para Multiplicar");
                    Console.WriteLine("Digite 4 para Dividir");
                    Console.WriteLine("Digite s para sair\n");
                    double pergunta = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite o primeiro número: ");
                    int n3 = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite o segundo número: ");
                    int n4 = int.Parse(Console.ReadLine());

                    int resultado = 0;

                    if (pergunta == 1)
                    {
                        resultado = n3 + n4;
                    }

                    else if (pergunta == 2)
                    {
                        resultado = n3 - n4;
                    }

                    else if (pergunta == 3)
                    {
                        resultado = n3 * n4;
                    }

                    else if (pergunta == 4)
                    {
                        resultado = n3 / n4;
                    }

                    else if (pergunta == 5)
                    {
                        break;
                    }

                    Console.WriteLine($"\nO resultado da sua operação é: {resultado}");
                }
            }
    }
}