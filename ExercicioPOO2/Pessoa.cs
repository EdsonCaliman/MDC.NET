using System;

namespace ExercicioPOO2
{
    class Pessoa
    {
        private string _nome;

        public string PegarNome()
        {
            return _nome;
        }

        public void DefinirNome(string value)
        {
            _nome = value;
        }

        private DateTime _dataNascimento;

        public DateTime PegarDataNascimento()
        {
            return _dataNascimento;
        }

        public void DefinirDataNascimento(DateTime value)
        {
            _dataNascimento = value;
        }

        private double _altura;

        public double PegarAltura()
        {
            return _altura;
        }

        public void DefinirAltura(double value)
        {
            _altura = value;
        }

        public override string ToString()
        {
            return $"Nome: {_nome}" +
                $" Data Nascimento: {_dataNascimento:dd/MM/yyyy}" +
                $" Altura: {_altura}" +
                $" Idadde: {RetornarIdadedaPessoa()}";
        }

        public int RetornarIdadedaPessoa()
        {
            return DateTime.Today.Year - _dataNascimento.Year;
        }
    }
}
