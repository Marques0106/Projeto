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
        inicio:
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("--------Simples Calculadora no Console--------");
            Console.WriteLine("----------------------------------------------");

            
            Console.WriteLine("Com base nas opções abaixo, digite o número que se adeque a operação desejada: ");
            Console.WriteLine("1 - Adição; ");
            Console.WriteLine("2 - Subtração; ");
            Console.WriteLine("3 - Multiplicação; ");
            Console.WriteLine("4 - Divisão; ");
            Console.WriteLine("5 - Sair; \n");
            int opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o valor de A: "); 
                    double AdicaovalorA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B: ");
                    double AdicaovalorB = double.Parse(Console.ReadLine());
                    double AdicaovalorTotal = AdicaovalorA + AdicaovalorB;
                    Console.WriteLine("O valor resulta em: " + AdicaovalorTotal.ToString("F3", CultureInfo.CurrentCulture));
                    break;



                case 2:
                    Console.WriteLine("Digite o valor de A");
                    double SubtracaovalorA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B");
                    double SubtracaovalorB = double.Parse(Console.ReadLine());
                    double SubtracaovalorTotal = SubtracaovalorA - SubtracaovalorB;
                    Console.WriteLine("O valor resulta em: " + SubtracaovalorTotal.ToString("F3", CultureInfo.CurrentCulture));
                    break;

                case 3:
                    Console.WriteLine("Digite o valor de A");
                    double MultivalorA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B");
                    double MultivalorB = double.Parse(Console.ReadLine());
                    double MultivalorTotal = MultivalorA * MultivalorB;
                    Console.WriteLine("O valor resulta em: " + MultivalorTotal.ToString("F3", CultureInfo.CurrentCulture));
                    break;
                case 4:
                    Console.WriteLine("Digite o valor de A");
                    double DividvalorA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B");
                    double DividvalorB = double.Parse(Console.ReadLine());
                    double DividvalorTotal = DividvalorA / DividvalorB;
                    Console.WriteLine("O valor resulta em: " + DividvalorTotal.ToString("F3", CultureInfo.CurrentCulture));
                    break;
                case 5:
                default:
                    break;
            }
            Console.WriteLine("\nDeseja continuar?");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Continuar");
            double opcao2 = double.Parse(Console.ReadLine());

            if (opcao2 == 1)
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("O programa foi finalizado, obrigado por utilizar");

            }
        }
    }
}
