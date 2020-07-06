using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;

//https://www.caelum.com.br/apostila-csharp-orientacao-objetos/linq-e-lambda/#outros-mtodos-do-linq

namespace Exercicio9
{
    class Program
    {
        static List<int> valores = new List<int>();

        static void Main(string[] args)
        {
            EntradaDeDados();

            ApresentarMenu();

        }

        static void EntradaDeDados()
        {
            string valor = "";
            while (!valor.ToUpper().Contains('S'))
            {
                Console.WriteLine("Digite o valor ou S para terminar:");
                valor = Console.ReadLine();
                if (!valor.ToUpper().Contains('S'))
                {
                    valores.Add(IntegerType.FromString(valor));
                }
            }
        }

        static void ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Imprimir todos os números da lista");
            Console.WriteLine("2 - Imprimir todos os números da lista na ordem crescente");
            Console.WriteLine("3 - Imprimir todos os números da lista na ordem decrescente");
            Console.WriteLine("4 - Imprima apenas o primeiro número da lista");
            Console.WriteLine("5 - Imprima apenas o ultimo número da lista");
            Console.WriteLine("6 - Insira um numero no inicio da lista");
            Console.WriteLine("7 - Insira um numero no final da lista");
            Console.WriteLine("8 - Remova o primeiro número");
            Console.WriteLine("9 - Remova o ultimo número");
            Console.WriteLine("10 - Retorne apenas os número pares");
            Console.WriteLine("11 - Retorne apenas o número informado");
            Console.WriteLine("12 - Transforme todos os numero da lista em um array");
            Console.WriteLine("S - Sair");
            var opcao = Console.ReadLine().ToUpper();
            switch (opcao)
            {
                case "1":
                    ImprimirTodosOsNumerosDaLista();
                    ApresentarMenu();
                    break;
                case "2":
                    ImprimirTodosOsNumerosCrescente();
                    ApresentarMenu();
                    break;
                case "3":
                    ImprimirTodosOsNumerosDecrescente();
                    ApresentarMenu();
                    break;
                case "4":
                    ImprimirPrimeiroNumero();
                    ApresentarMenu();
                    break;
                case "5":
                    ImprimirUltimoNumero();
                    ApresentarMenu();
                    break;
                case "6":
                    InserirNoInicioDaLista();
                    ApresentarMenu();
                    break;
                case "7":
                    InserirNoFinalDaLista();
                    ApresentarMenu();
                    break;
                case "8":
                    RemoverPrimeiroNumero();
                    ApresentarMenu();
                    break;
                case "9":
                    RemoverUltimoNumero();
                    ApresentarMenu();
                    break;
                case "10":
                    RetornarApenasNumerosPares();
                    ApresentarMenu();
                    break;
                case "11":
                    RetorneApenasNumeroInformado();
                    ApresentarMenu();
                    break;
                case "12":
                    TransformarListaEmArray();
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

        private static void TransformarListaEmArray()
        {
            var valoresArray = valores.ToArray();

            Console.WriteLine("Exibindo dados do array");
            foreach (var item in valoresArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

        private static void RetorneApenasNumeroInformado()
        {
            var valorInformado = Console.ReadLine();
            var valorRetornado = valores.Find(valor => valor == IntegerType.FromString(valorInformado));
            
            if (valorRetornado != 0)
            {
                Console.WriteLine($"Valor encontrado: {valorRetornado}");
            }
            else
            {
                Console.WriteLine("Valor não encontrado");
            }
            
            Console.ReadLine();
        }

        private static void RetornarApenasNumerosPares()
        {
            var valoresPares = valores.Where(valor => valor%2==0);
            valoresPares.ToList().ForEach(v => Console.WriteLine(v));
            Console.ReadLine();
        }

        private static void RemoverPrimeiroNumero()
        {
            valores.RemoveAt(0);
        }

        private static void RemoverUltimoNumero()
        {
            valores.RemoveAt(valores.LastIndexOf(valores.LastOrDefault()));
        }

        private static void InserirNoFinalDaLista()
        {
            Console.WriteLine("Digite o valor: ");
            var valor = Console.ReadLine();
            valores.Add(IntegerType.FromString(valor));
            Console.WriteLine("Valor Inserido");
            Console.ReadLine();
        }

        private static void InserirNoInicioDaLista()
        {
            Console.WriteLine("Digite o valor: ");
            var valor = Console.ReadLine();
            valores.Insert(0, IntegerType.FromString(valor));
            Console.WriteLine("Valor Inserido");
            Console.ReadLine();
        }

        private static void ImprimirUltimoNumero()
        {
            Console.WriteLine(valores.LastOrDefault());
            Console.ReadLine();
        }

        private static void ImprimirPrimeiroNumero()
        {
            Console.WriteLine(valores.FirstOrDefault());
            Console.ReadLine();
        }

        private static void ImprimirTodosOsNumerosDecrescente()
        {
            var valoresOrdenados = from valor in valores
                                   orderby valor descending
                                   select valor;

            valoresOrdenados.ToList().ForEach(v => Console.WriteLine(v));
            Console.ReadLine();
        }

        private static void ImprimirTodosOsNumerosCrescente()
        {
            var valoresOrdenados = from valor in valores
                                   orderby valor ascending
                                   select valor;

            valoresOrdenados.ToList().ForEach(v => Console.WriteLine(v));
            Console.ReadLine();
        }

        private static void ImprimirTodosOsNumerosDaLista()
        {
            valores.ForEach(v => Console.WriteLine(v));
            Console.ReadLine();
        }

        private static void FecharPrograma()
        {
            Environment.Exit(0);
        }
    }
}
