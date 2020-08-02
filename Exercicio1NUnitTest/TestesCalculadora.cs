using Exercicio1;
using NUnit.Framework;

namespace Exercicio1NUnitTest
{
    public class TestesCalculadora
    {
        private Calculadora _calculadora;

        [SetUp]
        public void Setup()
        {
            _calculadora = new Calculadora();
        }

        [Test]
        public void TesteSomarValores()
        {
            _calculadora.ValorA = 10;
            _calculadora.ValorB = 20;
            var esperado = _calculadora.SomarValores();
            Assert.AreEqual("Resultado: 30", esperado);
        }

        [Test]
        public void TesteSubtrairValores()
        {
            _calculadora.ValorA = 20;
            _calculadora.ValorB = 10;
            var resultado = _calculadora.SubtrairValores();
            Assert.AreEqual("Resultado: 10", resultado);
        }

        [Test]
        public void TesteDividirValores()
        {
            _calculadora.ValorA = 5;
            _calculadora.ValorB = 10;
            var resultado = _calculadora.DividirValores();
            Assert.AreEqual("Resultado: 2", resultado);
        }

        [Test]
        public void TesteDividirValoresDivisaoPorZero()
        {
            _calculadora.ValorA = 0;
            _calculadora.ValorB = 10;
            var resultado = _calculadora.DividirValores();
            Assert.AreEqual("Divisão por zero!", resultado);
        }

        [Test]
        public void TesteMultiplicarValores()
        {
            _calculadora.ValorA = 5;
            _calculadora.ValorB = 5;
            var resultado = _calculadora.MultiplicarValores();
            Assert.AreEqual("Resultado: 25", resultado);
        }
    }
}