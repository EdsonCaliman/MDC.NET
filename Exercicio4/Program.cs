using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        public const string OpcaoIncluirAluno = "1 - Incluir Aluno";
        public const string OpcaoImprimirTodosOsAlunosComMediaSuperiorASete = "2 - Imprimir todos os alunos com medias superiores a 7";
        public const string OpcaoSair = "S - Sair";
        public const string DigiteONomeDoAluno = "Digite o nome do aluno:";
        public const string DigiteANotaDoAluno = "Digite a nota do Aluno:";
        public const string MensagemInformeUmaNotaValida = "Informe uma nota válida!";
        public const string MensagemOValorInformadoEstaForaDaFaixa = "O valor informado está fora da faixa permitida!";
        public const string MensagemAlunosComMediaSuperiorASete = "Aluno: {0} nota: {1}";

        public static List<Aluno> ListaAlunos = new List<Aluno>();
        static void Main(string[] args)
        {
            ApresentarMenu();
        }

        private static void ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine(OpcaoIncluirAluno);
            Console.WriteLine(OpcaoImprimirTodosOsAlunosComMediaSuperiorASete);
            Console.WriteLine(OpcaoSair);
            var opcao = Console.ReadLine().ToUpper();
            switch (opcao)
            {
                case "1":
                    IncluirAluno();
                    ApresentarMenu();
                    break;
                case "2":
                    ImprimirAlunosComMediaMaiorQueSete();
                    ApresentarMenu();
                    break;
                case "S":
                    FecharPrograma();
                    break;
                default:
                    break;
            }
        }

        private static void FecharPrograma()
        {
            Environment.Exit(0);
        }

        private static void IncluirAluno()
        {
            Console.WriteLine(DigiteONomeDoAluno);
            var nome = Console.ReadLine();

            var aluno = new Aluno
            {
                Nome = nome,
                Nota = InformarNota()
            };

            ListaAlunos.Add(aluno);
        }

        private static double InformarNota()
        {
            Console.WriteLine(DigiteANotaDoAluno);
            try
            {
                var nota = Console.ReadLine();
                return double.Parse(nota, CultureInfo.CurrentCulture);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine(MensagemInformeUmaNotaValida);
                return InformarNota();
            }
            catch (FormatException)
            {
                Console.WriteLine(MensagemInformeUmaNotaValida);
                return InformarNota();
            }
            catch (OverflowException)
            {
                Console.WriteLine(MensagemOValorInformadoEstaForaDaFaixa);
                return InformarNota();
            }
        }

        private static void ImprimirAlunosComMediaMaiorQueSete()
        {
            Console.Clear();
            foreach (var aluno in ListaAlunos)
            {
                if (aluno.AlunoComNotaMaiorQueSete())
                {
                    Console.WriteLine(MensagemAlunosComMediaSuperiorASete, aluno.Nome, aluno.Nota);
                }
            }
            Console.ReadLine();
        }
    }
}
