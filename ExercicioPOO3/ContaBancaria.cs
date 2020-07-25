using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO3
{
    abstract class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }

        public abstract void Sacar(double valor);

        public abstract void Depositar(double valor);

        protected abstract void ValidarSaldoSuficiente(double valor);
    }
}
