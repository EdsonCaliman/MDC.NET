using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digitar o número {0}", i+1);
                numeros[i] = IntegerType.FromString(Console.ReadLine());
            }

            var soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                var resto = numeros[i] % 2;
                if (resto == 0)
                {
                    soma += numeros[i];
                }
            }

            Console.WriteLine("A soma dos números pares é: " + soma);
            Console.ReadLine();
        }
    }
}
