using Exercicio4;
using NUnit.Framework;

namespace Exercicio4NUnitTest
{
    public class Tests
    {
        private Aluno _aluno;

        [SetUp]
        public void Setup()
        {
            _aluno = new Aluno();
        }

        [Test]
        public void TesteAlunoComNotaMaiorQueSete()
        {
            _aluno.Nome = "MaiorQueSete";
            _aluno.Nota = 8;

            Assert.IsTrue(_aluno.AlunoComNotaMaiorQueSete());
        }

        [Test]
        public void TesteAlunoComNotaMenorQueSete()
        {
            _aluno.Nome = "MenorQueSete";
            _aluno.Nota = 5;

            Assert.IsFalse(_aluno.AlunoComNotaMaiorQueSete());
        }
    }
}