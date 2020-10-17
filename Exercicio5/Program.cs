using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularFormulaDeBhaskara();
        }

        private static void CalcularFormulaDeBhaskara()
        {
            Console.WriteLine("Calculo da fórmula de Bhaskara");
            Console.WriteLine("Digite o valor a:");
            var valorA = Console.ReadLine();
            Console.WriteLine("Digite o valor b:");
            var valorB = Console.ReadLine();
            Console.WriteLine("Digite o valor c:");
            var valorC = Console.ReadLine();

            try
            {
                var a = Convert.ToDouble(valorA);
                var b = Convert.ToDouble(valorB);
                var c = Convert.ToDouble(valorC);

                double delta = Math.Pow(b, 2) - (4 * a * c);
                double raiz = Math.Sqrt(delta);
                var r1 = ((-b) + raiz) / (2 * a);
                var r2 = ((-b) - raiz) / (2 * a);

                Console.WriteLine("Valor de R1: {0}", r1);
                Console.WriteLine("Valor de R2: {0}", r2);
            }
            catch (Exception)
            {
                Console.WriteLine("Os valores informados devem ser números");
                Console.ReadLine();
                CalcularFormulaDeBhaskara();
                return;
            }

        }
    }
}
