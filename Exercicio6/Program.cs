using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorOut = 20;
            int valorRef = 20;
            int valor = 20;
            Console.WriteLine("Valor SomarRef:" + SomarRef(ref valorOut)); //não altera o valor
            Console.WriteLine("Valor SomarOut:" + SomarOut(out valorRef)); //altera o valor, mas deve ser inicializado, exclusivo para retorno
            Console.WriteLine("Valor Somar:" + Somar(valor)); //default ref
        }

        private static int Somar(int valor)
        {
            return valor + valor;
        }

        private static int SomarOut(out int valorRef)
        {
            valorRef = 0;
            return valorRef + valorRef;
        }

        private static int SomarRef(ref int valorOut)
        {
            return valorOut + valorOut;
        }
    }
}
