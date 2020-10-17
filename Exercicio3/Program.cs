using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Múltiplos de 3, entre 1 e 100:");
            var contador = 1;
            int resto;
            while (contador <= 100)
            {
                resto = contador % 3;
                if (resto == 0) 
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }
        }
    }
}
