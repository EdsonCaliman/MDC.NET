using System;

namespace Exercicio1
{
    class Program
    {
        private static Calculadora Calculadora;

        static void Main(string[] args)
        {
            Calculadora = new Calculadora();
            Console.WriteLine("Digite o primeiro valor: ");
            Calculadora.ValorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            Calculadora.ValorB = int.Parse(Console.ReadLine());

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
                    Console.WriteLine(Calculadora.SomarValores());
                    Console.ReadLine();
                    ApresentarMenu();
                    break;
                case "2":
                    Console.WriteLine(Calculadora.SubtrairValores());
                    Console.ReadLine();
                    ApresentarMenu();
                    break;
                case "3":
                    Console.WriteLine(Calculadora.DividirValores());
                    Console.ReadLine();
                    ApresentarMenu();
                    break;
                case "4":
                    Console.WriteLine(Calculadora.MultiplicarValores());
                    Console.ReadLine();
                    ApresentarMenu();
                    break;
                case "5":
                    Console.WriteLine(Calculadora.ImprimirParOuImpar());
                    Console.ReadLine();
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

        
    }
}
