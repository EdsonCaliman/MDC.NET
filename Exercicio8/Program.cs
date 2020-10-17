using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> valores = new List<double>();

            string valor = "";
            while (!valor.Contains('S'))
            {
                Console.WriteLine("Digite o valor ou S para terminar:");
                valor = Console.ReadLine();
                if (!valor.Contains('S'))
                {
                    valores.Add(DoubleType.FromString(valor));
                }
            }

            Console.WriteLine("Crescente");
            foreach (var item in valores.OrderBy(v => v))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Decrescente");
            foreach (var item in valores.OrderByDescending(v => v))
            {
                Console.WriteLine(item);
            }

        }
    }
}
