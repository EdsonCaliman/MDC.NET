using System;

namespace Exercicio1
{
    public class Calculadora
    {
        public int ValorA { get; set; }
        public int ValorB { get; set; }
        public string ImprimirParOuImpar()
        {
            var valor1EhPar = ValorA % 2 == 0;
            var valor2EhPar = ValorB % 2 == 0;

            return "Valor1 é Par? " + valor1EhPar + "\n" + "Valor2 é Par? " + valor2EhPar;

        }

        public string MultiplicarValores()
        {
            var multiplicacao = ValorA * ValorB;

            return "Resultado: " + multiplicacao;        
        }

        public string DividirValores()
        {
            try
            {
                var divisao = ValorB / ValorA;
                return "Resultado: " + divisao;
            }
            catch (DivideByZeroException)
            {
                return "Divisão por zero!";
            }
        }

        public string SubtrairValores()
        {
            var subtracao = ValorA - ValorB;
            return "Resultado: " + subtracao;
        }

        public string SomarValores()
        {
            var soma = ValorA + ValorB;
            return "Resultado: " + soma;
        }
    }
}
