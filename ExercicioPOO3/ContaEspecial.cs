using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO3
{
    class ContaEspecial : ContaBancaria, IImprimivel
    {
        public double LimiteEspecial { get; set; }
        public override void Depositar(double valor)
        {
            this.Saldo = this.Saldo + valor;
        }

        public string MostrarDados()
        {
            return "Conta Especial: " + this.NumeroConta + " Limite Especial: " + this.LimiteEspecial + " Saldo: " + this.Saldo;
        }

        public override void Sacar(double valor)
        {
            ValidarSaldoSuficiente(valor);
            this.Saldo = this.Saldo - valor;
        }

        protected override void ValidarSaldoSuficiente(double valor)
        {
            var saldoTotal = this.Saldo + LimiteEspecial;
            if ((saldoTotal - valor) < 0)
            {
                throw new ERegraNegocioException("Saldo Insuficiente!");
            }
            
        }
    }
}
