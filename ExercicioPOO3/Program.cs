using System;

namespace ExercicioPOO3
{
    class Program
    {
        static void Main(string[] args)
        {
            var qtdeContas = 1;
            while (qtdeContas <= 2)
            {
                var contaCorrente = new ContaCorrente();
                Console.WriteLine("Digite o número da Conta Corrente {0}", qtdeContas);
                contaCorrente.NumeroConta = Console.ReadLine();
                Console.WriteLine("Digite a taxa de operação da conta {0}", qtdeContas);
                contaCorrente.TaxadeOperacao = Double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de deposito na conta {0}", qtdeContas);
                contaCorrente.Depositar(Double.Parse(Console.ReadLine()));
                Console.WriteLine("Digite o valor de saque da conta {0}", qtdeContas);
                try
                {
                    contaCorrente.Sacar(Double.Parse(Console.ReadLine()));
                }
                catch (ERegraNegocioException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(contaCorrente.MostrarDados());
                Console.WriteLine("============================================");
                qtdeContas++;
            }

            qtdeContas = 1;
            while (qtdeContas <= 2)
            {
                var contaEspecial = new ContaEspecial();
                Console.WriteLine("Digite o número da Conta Especial {0}", qtdeContas);
                contaEspecial.NumeroConta = Console.ReadLine();
                Console.WriteLine("Digite o Limite Especial da conta {0}", qtdeContas);
                contaEspecial.LimiteEspecial = Double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de deposito na conta {0}", qtdeContas);
                contaEspecial.Depositar(Double.Parse(Console.ReadLine()));
                Console.WriteLine("Digite o valor de saque da conta {0}", qtdeContas);
                try
                {
                    contaEspecial.Sacar(Double.Parse(Console.ReadLine()));
                }
                catch (ERegraNegocioException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(contaEspecial.MostrarDados());
                Console.WriteLine("============================================");
                qtdeContas++;
            }
        }
    }
}
