using System;

namespace Exercicio1
{
    class Program
    {
        static int valorA = 0;
        static int valorB = 0;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            valorA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            valorB = Int32.Parse(Console.ReadLine());

            ApresentarMenu();

        }

        static void ApresentarMenu()
        {
            Console.Clear();    
            Console.WriteLine("1 - Some esses 2 valores");
            Console.WriteLine("2 - Faça uma subtração do valor A - B");
            Console.WriteLine("3 - Divida o valor B por A");
            Console.WriteLine("4 - Multiplique o valor A por B");
            Console.WriteLine("5 - Imprima os valores de entrada, informado se o número é par ou impar");
            Console.WriteLine("S - Sair");
            var opcao = Console.ReadLine().ToUpper();
            switch (opcao)
            {
                case "1":
                    SomarValores();
                    ApresentarMenu();
                    break;
                case "2":
                    SubtrairValores();
                    ApresentarMenu();
                    break;
                case "3":
                    DividirValores();
                    ApresentarMenu();
                    break;
                case "4":
                    MultiplicarValores();
                    ApresentarMenu();
                    break;
                case "5":
                    ImprimirParOuImpar();
                    ApresentarMenu();
                    break;
                case "S":
                    FecharPrograma();
                    break;
                default:
                    Console.WriteLine("A opção não é válida!!!");
                    ApresentarMenu();
                    break;
            }
        }

        private static void FecharPrograma()
        {
            Environment.Exit(0);
        }

        private static void ImprimirParOuImpar()
        {
            var valor1EhPar = valorA % 2 == 0;
            var valor2EhPar = valorB % 2 == 0;

            Console.WriteLine($"Valor1 é Par? {valor1EhPar}");
            Console.WriteLine($"Valor2 é Par? {valor2EhPar}");
            Console.ReadLine();
        }

        private static void MultiplicarValores()
        {
            var multiplicacao = valorA * valorB;
            Console.WriteLine("Resultado: {0}", multiplicacao);
            Console.ReadLine();
        }

        private static void DividirValores()
        {
            try
            {
                var divisao = valorB / valorA;
                Console.WriteLine("Resultado: {0}", divisao);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Divisão por zero!");
            }
            Console.ReadLine();

        }

        private static void SubtrairValores()
        {
            var subtracao = valorA - valorB;
            Console.WriteLine("Resultado: {0}", subtracao);
            Console.ReadLine();
        }

        private static void SomarValores()
        {
            var soma = valorA + valorB;
            Console.WriteLine("Resultado: {0}", soma);
            Console.ReadLine();
        }
    }
}
