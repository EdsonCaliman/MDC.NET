using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO3
{

    class ContaCorrente : ContaBancaria, IImprimivel
    {
        public double TaxadeOperacao { get; set; }
        public override void Depositar(double valor)
        {
            var valorTaxa = CalcularTaxaPelaOperacao(valor);
            this.Saldo = this.Saldo + valor - valorTaxa;
        }

        public string MostrarDados()
        {
            return "Conta Corrente: " + this.NumeroConta + " Taxa de Operação: " + this.TaxadeOperacao + " Saldo: " + this.Saldo;
        }

        public override void Sacar(double valor)
        {
            var valorTaxa = CalcularTaxaPelaOperacao(valor);
            ValidarSaldoSuficiente(valorTaxa + valor);
            this.Saldo = this.Saldo - valor - valorTaxa;
        }

        protected override void ValidarSaldoSuficiente(double valor)
        {
            if ((this.Saldo - valor) < 0)
            {
                throw new ERegraNegocioException("Saldo Insuficiente!");
            }
        }

        private double CalcularTaxaPelaOperacao(double valor)
        {
            return (valor * TaxadeOperacao / 100);
        }
    }
}
