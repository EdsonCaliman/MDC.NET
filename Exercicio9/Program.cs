using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio9
{
    class Program
    {
        static readonly List<int> valores = new List<int>();

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
                Console.WriteLine("Digite o valor e pressione enter ou S para ir ao menu:");
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
            Console.Clear();
            var valoresArray = valores.ToArray();

            Console.WriteLine("Exibindo dados do array");
            foreach (var item in valoresArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Pressione enter pra voltar ao menu");
            Console.ReadLine();

        }

        private static void RetorneApenasNumeroInformado()
        {
            Console.Clear();
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
            Console.WriteLine("Pressione enter pra voltar ao menu");
            Console.ReadLine();
        }

        private static void RetornarApenasNumerosPares()
        {
            Console.Clear();
            var valoresPares = valores.Where(valor => valor%2==0);
            valoresPares.ToList().ForEach(v => Console.WriteLine(v));
            Console.WriteLine("Pressione enter pra voltar ao menu");
            Console.ReadLine();
        }

        private static void RemoverPrimeiroNumero()
        {
            Console.Clear();
            valores.RemoveAt(0);
            Console.WriteLine("Registro removido, pressione enter pra voltar ao menu");
            Console.ReadLine();
        }

        private static void RemoverUltimoNumero()
        {
            Console.Clear();
            valores.RemoveAt(valores.LastIndexOf(valores.LastOrDefault()));
            Console.WriteLine("Registro removido, pressione enter pra voltar ao menu");
            Console.ReadLine();
        }

        private static void InserirNoFinalDaLista()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor: ");
            var valor = Console.ReadLine();
            valores.Add(IntegerType.FromString(valor));
            Console.WriteLine("Valor Inserido");
            Console.WriteLine("Pressione enter pra voltar ao menu");
            Console.ReadLine();
        }

        private static void InserirNoInicioDaLista()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor: ");
            var valor = Console.ReadLine();
            valores.Insert(0, IntegerType.FromString(valor));
            Console.WriteLine("Valor Inserido");
            Console.WriteLine("Pressione enter pra voltar ao menu");
            Console.ReadLine();
        }

        private static void ImprimirUltimoNumero()
        {
            Console.Clear();
            Console.WriteLine(valores.LastOrDefault());
            Console.WriteLine("Pressione enter pra voltar ao menu");
            Console.ReadLine();
        }

        private static void ImprimirPrimeiroNumero()
        {
            Console.Clear();
            Console.WriteLine(valores.FirstOrDefault());
            Console.WriteLine("Pressione enter pra voltar ao menu");
            Console.ReadLine();
        }

        private static void ImprimirTodosOsNumerosDecrescente()
        {
            Console.Clear();
            var valoresOrdenados = from valor in valores
                                   orderby valor descending
                                   select valor;

            valoresOrdenados.ToList().ForEach(v => Console.WriteLine(v));
            Console.WriteLine("Pressione enter pra voltar ao menu");
            Console.ReadLine();
        }

        private static void ImprimirTodosOsNumerosCrescente()
        {
            Console.Clear();
            var valoresOrdenados = from valor in valores
                                   orderby valor ascending
                                   select valor;

            valoresOrdenados.ToList().ForEach(v => Console.WriteLine(v));
            Console.WriteLine("Pressione enter pra voltar ao menu");
            Console.ReadLine();
        }

        private static void ImprimirTodosOsNumerosDaLista()
        {
            Console.Clear();
            valores.ForEach(v => Console.WriteLine(v));
            Console.WriteLine("Pressione enter pra voltar ao menu");
            Console.ReadLine();
        }

        private static void FecharPrograma()
        {
            Environment.Exit(0);
        }
    }
}
