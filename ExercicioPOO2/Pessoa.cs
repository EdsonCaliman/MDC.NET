using System;

namespace ExercicioPOO2
{
    class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        private DateTime _dataNascimento;

        public DateTime DataNascimento
        {
            get => _dataNascimento;
            set => _dataNascimento = value;
        }

        private double _altura;
        public double Altura
        {
            get => _altura;
            set => _altura = value;
        }

        public Pessoa(string nome, DateTime datanascimento, double altura)
        {
            _nome = nome;
            _dataNascimento = datanascimento;
            _altura = altura;
        }

        public override string ToString()
        {
            return "Nome: " + _nome + " Data Nascimento: " + (_dataNascimento.ToString("dd/MM/yyyy")) + " Altura: " + _altura + " Idade: " + this.RetornarIdadedaPessoa();
        }

        public int RetornarIdadedaPessoa()
        {
            return DateTime.Today.Year - _dataNascimento.Year;
        }
    }
}
