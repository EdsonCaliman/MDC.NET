namespace ExercicioPOO3
{

    class ContaCorrente : ContaBancaria, IImprimivel
    {
        public double TaxadeOperacao { get; set; }
        public override void Depositar(double valor)
        {
            var valorTaxa = CalcularTaxaPelaOperacao(valor);
            Saldo = Saldo + valor - valorTaxa;
        }

        public string MostrarDados()
        {
            return $"Conta Corrente: { NumeroConta } " +
                $"Taxa de Operação: { TaxadeOperacao } " +
                $"Saldo: { Saldo }";
        }

        public override void Sacar(double valor)
        {
            var valorTaxa = CalcularTaxaPelaOperacao(valor);
            ValidarSaldoSuficiente(valorTaxa + valor);
            Saldo = Saldo - valor - valorTaxa;
        }

        protected override void ValidarSaldoSuficiente(double valor)
        {
            if ((Saldo - valor) < 0)
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
