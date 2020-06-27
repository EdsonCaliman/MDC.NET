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
            List<Double> valores = new List<Double>();

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

            List<Double> valoresOrdenadosCrescente = valores.OrderBy(v => v).ToList();

            Console.WriteLine("Crescente");
            foreach (var item in valoresOrdenadosCrescente)
            {
                Console.WriteLine(item);
            }

            List<Double> valoresOrdenadosDecrescente = valores.OrderByDescending(v => v).ToList();

            Console.WriteLine("Decrescente");
            valoresOrdenadosDecrescente.ForEach(v => Console.WriteLine(v));

        }
    }
}
