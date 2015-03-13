using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExemploTesteUnidade.Test
{
    [TestClass]
    public class CalculadoraTest
    {

        private Calculadora target;

        [TestInitialize]
        public void IniciarTestes()
        {
            target = new Calculadora();
        }

        [TestMethod]
        public void DeveSomarDezComCincoEResultadoDeveSerQuinze()
        {
            decimal expected = 15;
            decimal actual = 0;

            actual = target.Somar(10, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeveSomarVinteComQuinzeEResultadoDeveSerTrintaECinco()
        {
            decimal expected = 35;
            decimal actual = 0;

            actual = target.Somar(20, 15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeveSubtrairOnzeDeVinteEResultadoDeveSerNove()
        {
            decimal expected = 9;
            decimal actual = 0;

            actual = target.Subtrair(20, 11);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeveSubtrairTresDeSeteEResultadoDeveSerQuatro()
        {
            decimal expected = 4;
            decimal actual = 0;

            actual = target.Subtrair(7, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeveMultiplicarCincoPorTresEResultadoDeveSerQuinze()
        {
            decimal expected = 15;
            decimal actual = 0;

            actual = target.Multiplicar(5, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeveMultiplicarQuatroPorSeteEResultadoDeveSerVinteEOito()
        {
            decimal expected = 28;
            decimal actual = 0;

            actual = target.Multiplicar(4, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeveDividirOitoPorDoisEResultadoDeveSerQuatro()
        {
            decimal expected = 4;
            decimal actual = 0;

            actual = target.Dividir(8, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeveDividirODezoitoPorSeisEResultadoDeveSerTres()
        {
            decimal expected = 3;
            decimal actual = 0;

            actual = target.Dividir(18, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveLancarExcecaoAoDividirQualquerNumeroPorZero()
        {
            target.Dividir(10, 0);
        }

    }
}
