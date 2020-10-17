namespace ExercicioPOO3
{
    class ContaEspecial : ContaBancaria, IImprimivel
    {
        public double LimiteEspecial { get; set; }
        public override void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }

        public string MostrarDados()
        {
            return $"Conta Especial: { NumeroConta } " +
                $"Limite Especial: { LimiteEspecial } " +
                $"Saldo: { Saldo }";
        }

        public override void Sacar(double valor)
        {
            ValidarSaldoSuficiente(valor);
            Saldo = Saldo - valor;
        }

        protected override void ValidarSaldoSuficiente(double valor)
        {
            var saldoTotal = Saldo + LimiteEspecial;
            if ((saldoTotal - valor) < 0)
            {
                throw new ERegraNegocioException("Saldo Insuficiente!");
            }
            
        }
    }
}
