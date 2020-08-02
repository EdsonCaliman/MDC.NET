using Exercicio4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicio4MSTest
{
    [TestClass]
    public class TestesAluno
    {

        private Aluno _aluno;

        public TestesAluno()
        {
            _aluno = new Aluno();
        }

        [TestMethod]
        public void TesteAlunoComNotaMaiorQueSete()
        {
            _aluno.Nome = "MaiorQueSete";
            _aluno.Nota = 8;

            Assert.IsTrue(_aluno.AlunoComNotaMaiorQueSete());
        }
        [TestMethod]
        public void TesteAlunoComNotaMenorQueSete()
        {
            _aluno.Nome = "MenorQueSete";
            _aluno.Nota = 5;

            Assert.IsFalse(_aluno.AlunoComNotaMaiorQueSete());
        }
    }
}
