﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {

        public static List<Funcionario> ListaFuncionarios = new List<Funcionario>();
        static void Main(string[] args)
        {
            ApresentarMenu();
        }

        private static void ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Incluir funcionários");
            Console.WriteLine("2 - Imprimir o maior salário");
            Console.WriteLine("3 - Imprimir o menor salário");
            Console.WriteLine("S - Sair");
            var opcao = Console.ReadLine().ToUpper();
            switch (opcao)
            {
                case "1" :
                    IncluirFuncionarios();
                    ApresentarMenu();
                    break;
                case "2":
                    ImprimirMaiorSalario();
                    ApresentarMenu();
                    break;
                case "3":
                    ImprimirMenorSalario();
                    ApresentarMenu();
                    break;
                case "S":
                    FecharPrograma();
                    break;
                default:
                    break;
            }
        }

        private static void IncluirFuncionarios()
        {
            Console.WriteLine("Digite o nome do funcionário:");
            var nome = Console.ReadLine();

            var salario = InformarSalario();
         
            ListaFuncionarios.Add(new Funcionario(nome, salario));

        }

        private static Double InformarSalario()
        {

            Console.WriteLine("Digite o salario do funcionário:");
            try
            {
                var salario = Console.ReadLine();
                return double.Parse(salario, CultureInfo.CurrentCulture);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Informe um valor válido!");
                return InformarSalario();
            }
            catch (FormatException)
            {
                Console.WriteLine("Informe um valor válido!");
                return InformarSalario();
            }
            catch (OverflowException)
            {
                Console.WriteLine("O valor informado está fora da faixa permitida!");
                return InformarSalario();
            }
        }

        private static void ImprimirMaiorSalario()
        {
            double maiorSalario = 0;
            for (int i = 0; i < ListaFuncionarios.Count; i++)
            {
                if (ListaFuncionarios[i].Salario > maiorSalario)
                {
                    maiorSalario = ListaFuncionarios[i].Salario;
                }
            }
            Console.WriteLine($"O maior salario é: {maiorSalario}");
            Console.ReadLine();
        }

        private static void ImprimirMenorSalario()
        {
            double menorSalario = 0;
            var contador = 0;
            while (contador < ListaFuncionarios.Count)
            {
                if (contador == 0)
                {
                    menorSalario = ListaFuncionarios[contador].Salario;
                    contador++;
                    continue;
                }
                
                if (ListaFuncionarios[contador].Salario < menorSalario)
                {
                    menorSalario = ListaFuncionarios[contador].Salario;
                }
                contador++;
            }
            Console.WriteLine($"O menor salario é: {menorSalario}");
            Console.ReadLine();
        }

        private static void FecharPrograma()
        {
            Environment.Exit(0);
        }
    }

}
