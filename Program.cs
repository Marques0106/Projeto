using System;
using System.Globalization;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formatação do console
            Console.Title = "Calculadora - CONSOLE";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            
            
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("--------Simples Calculadora no Console--------");
            Console.WriteLine("----------------------------------------------");
            double valor_a, valor_b, valor_total;
            int opcao;


            Console.WriteLine("Com base nas opções abaixo, digite o número que se adeque a operação desejada: ");
            Console.WriteLine("1 - Adição; ");
            Console.WriteLine("2 - Subtração; ");
            Console.WriteLine("3 - Multiplicação; ");
            Console.WriteLine("4 - Divisão; ");
            Console.WriteLine("5 - Sair; \n");
            opcao = int.Parse(Console.ReadLine());

            while (opcao != 5)
            {
                switch (opcao)

                {
                    case 1:
                        Console.WriteLine("Digite o valor de A: ");
                        valor_a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor de B: ");
                        valor_b = double.Parse(Console.ReadLine());
                        valor_total = valor_a + valor_b;
                        Console.WriteLine("O valor resulta em: " + valor_total.ToString("F3", CultureInfo.CurrentCulture));
                        break;



                    case 2:
                        Console.WriteLine("Digite o valor de A");
                        valor_a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor de B");
                        valor_b = double.Parse(Console.ReadLine());
                        valor_total = valor_a - valor_b;
                        Console.WriteLine("O valor resulta em: " + valor_total.ToString("F3", CultureInfo.CurrentCulture));
                        break;

                    case 3:
                        Console.WriteLine("Digite o valor de A");
                        valor_a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor de B");
                        valor_b = double.Parse(Console.ReadLine());
                        valor_total = valor_a * valor_b;
                        Console.WriteLine("O valor resulta em: " + valor_total.ToString("F3", CultureInfo.CurrentCulture));
                        break;
                    case 4:
                        Console.WriteLine("Digite o valor de A");
                        valor_a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor de B");
                        valor_b = double.Parse(Console.ReadLine());
                        valor_total = valor_a / valor_b;
                        Console.WriteLine("O valor resulta em: " + valor_total.ToString("F3", CultureInfo.CurrentCulture));
                        break;
                    case 5:
                        default:
                        break;
                }

            }
        }
    }
}
