using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorRef = 20;
            int valor = 20;
            //Para ser passado via referência a variável deve ser inicializada
            Console.WriteLine("Passando o valor 20 por referência, e executando a soma do mesmo valor: " 
                + SomarRef(ref valorRef));
            //Para passar um argumento como ref não é necessário inicializar, pois deve ser inicializado dentro no método
            SomarOut(out int valorOut);
            Console.WriteLine("Passar argumento via ref, sem inicializar, retornado valor inicializado/calculado no método: " 
                + valorOut);
            //default c# é passar via referência
            Console.WriteLine("Default c# por referência, somar valor internamente: " + Somar(valor));
        }

        private static int Somar(int valor)
        {
            return valor + valor;
        }

        private static void SomarOut(out int valorOut)
        {
            valorOut = 10;
            valorOut += valorOut;
        }

        private static int SomarRef(ref int valorRef)
        {
            return valorRef + valorRef;
        }
    }
}
