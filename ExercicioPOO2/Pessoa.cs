using System;

namespace ExercicioPOO2
{
    class Pessoa
    {
        private string Nome;

        public string PegarNome()
        {
            return Nome;
        }

        public void DefinirNome(string value)
        {
            Nome = value;
        }

        private DateTime DataNascimento;

        public DateTime PegarDataNascimento()
        {
            return DataNascimento;
        }

        public void DefinirDataNascimento(DateTime value)
        {
            DataNascimento = value;
        }

        private double Altura;

        public double PegarAltura()
        {
            return Altura;
        }

        public void DefinirAltura(double value)
        {
            Altura = value;
        }

        public override string ToString()
        {
            return $"Nome: {PegarNome()}" +
                $" Data Nascimento: {PegarDataNascimento().ToString("dd/MM/yyyy")}" +
                $" Altura: {PegarAltura()}" +
                $" Idadde: {RetornarIdadedaPessoa()}";
        }

        public int RetornarIdadedaPessoa()
        {
            return DateTime.Today.Year - DataNascimento.Year;
        }
    }
}
