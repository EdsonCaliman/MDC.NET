using System;

namespace ExercicioPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Nome da Pessoa");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a Data de Nascimento DD/MM/YYYY");
            string datanascimento = Console.ReadLine();
            Console.WriteLine("Informe a altura");
            double altura = Convert.ToDouble(Console.ReadLine());

            Pessoa pessoa = new Pessoa();
            pessoa.DefinirNome(nome);
            pessoa.DefinirDataNascimento(Convert.ToDateTime(datanascimento));
            pessoa.DefinirAltura(altura);

            Console.WriteLine(pessoa.ToString());

        }
    }
}
