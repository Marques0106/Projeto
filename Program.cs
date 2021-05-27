using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        inicio:
            Console.Clear();
            Console.WriteLine("Projeto Calculádora CMD");

            Console.WriteLine("Com base nas alternativas abaixo, digite o número que se adeque a operação desejada");
            Console.WriteLine("1 - Adição; ");
            Console.WriteLine("2 - Subtração; ");
            Console.WriteLine("3 - Multiplicação; ");
            Console.WriteLine("4 - Divisão; ");
            Console.WriteLine("5 - Sair; ");
            int opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o valor de A");
                    double AdicaovalorA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B");
                    double AdicaovalorB = double.Parse(Console.ReadLine());
                    double AdicaovalorTotal = AdicaovalorA + AdicaovalorB;
                    Console.WriteLine("O valor é de " + AdicaovalorTotal);
                    break;



                case 2:
                    Console.WriteLine("Digite o valor de A");
                    double SubtracaovalorA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B");
                    double SubtracaovalorB = double.Parse(Console.ReadLine());
                    double SubtracaovalorTotal = SubtracaovalorA - SubtracaovalorB;
                    Console.WriteLine("O valor é de " + SubtracaovalorTotal);
                    break;

                case 3:
                    Console.WriteLine("Digite o valor de A");
                    double MultivalorA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B");
                    double MultivalorB = double.Parse(Console.ReadLine());
                    double MultivalorTotal = MultivalorA * MultivalorB;
                    Console.WriteLine("O valor é de " + MultivalorTotal);
                    break;
                case 4:
                    Console.WriteLine("Digite o valor de A");
                    double DividvalorA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B");
                    double DividvalorB = double.Parse(Console.ReadLine());
                    double DividvalorTotal = DividvalorA / DividvalorB;
                    Console.WriteLine("O valor é de " + DividvalorTotal);
                    break;
                case 5:
                default:
                    break;
            }
            Console.WriteLine("Deseja continuar?");
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
