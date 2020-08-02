using Exercicio1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicio1MSTest
{
    [TestClass]
    public class CalculadoraTest
    {
        private Calculadora _calculadora;

        public CalculadoraTest()
        {
            _calculadora = new Calculadora();
        }

        [TestMethod]
        public void TesteSomarValores()
        {
            _calculadora.ValorA = 10;
            _calculadora.ValorB = 10;
            var resultado = _calculadora.SomarValores();
            Assert.AreEqual("Resultado: 20", resultado);
        }

        [TestMethod]
        public void TesteSubtrairValores()
        {
            _calculadora.ValorA = 20;
            _calculadora.ValorB = 10;
            var resultado = _calculadora.SubtrairValores();
            Assert.AreEqual("Resultado: 10", resultado);
        }

        [TestMethod]
        public void TesteDividirValores()
        {
            _calculadora.ValorA = 5;
            _calculadora.ValorB = 10;
            var resultado = _calculadora.DividirValores();
            Assert.AreEqual("Resultado: 2", resultado);
        }

        [TestMethod]
        public void TesteDividirValoresDivisaoPorZero()
        {
            _calculadora.ValorA = 0;
            _calculadora.ValorB = 10;
            var resultado = _calculadora.DividirValores();
            Assert.AreEqual("Divisão por zero!", resultado);
        }

        [TestMethod]
        public void TesteMultiplicarValores()
        {
            _calculadora.ValorA = 5;
            _calculadora.ValorB = 5;
            var resultado = _calculadora.MultiplicarValores();
            Assert.AreEqual("Resultado: 25", resultado);
        }
    }
}
