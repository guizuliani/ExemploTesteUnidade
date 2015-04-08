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
        public void Somar_DeveSomar10Com5_ResultadoDeveSer15()
        {
            decimal expected = 15;
            decimal actual = 0;

            actual = target.Somar(10, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Somar_DeveSomar20Com15_ResultadoDeveSer35()
        {
            decimal expected = 35;
            decimal actual = 0;

            actual = target.Somar(20, 15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtrair_DeveSubtrair11De20_ResultadoDeveSer9()
        {
            decimal expected = 9;
            decimal actual = 0;

            actual = target.Subtrair(20, 11);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtrair_DeveSubtrair3De7_ResultadoDeveSer4()
        {
            decimal expected = 4;
            decimal actual = 0;

            actual = target.Subtrair(7, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiplicar_DeveMultiplicar5Por3_ResultadoDeveSer15()
        {
            decimal expected = 15;
            decimal actual = 0;

            actual = target.Multiplicar(5, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiplicar_DeveMultiplicar4Por7_ResultadoDeveSer28()
        {
            decimal expected = 28;
            decimal actual = 0;

            actual = target.Multiplicar(4, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Dividir_DeveDividir8Por2_ResultadoDeveSer4()
        {
            decimal expected = 4;
            decimal actual = 0;

            actual = target.Dividir(8, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Dividir_DeveDividir18Por6_ResultadoDeveSer3()
        {
            decimal expected = 3;
            decimal actual = 0;

            actual = target.Dividir(18, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Dividir_Dividir10Por0_ResultadoDeveSerArgumentException()
        {
            target.Dividir(10, 0);
        }

    }
}
