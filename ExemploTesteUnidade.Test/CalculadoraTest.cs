using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExemploTesteUnidade.Test
{
    [TestClass]
    public class CalculadoraTest
    {

        [TestMethod]
        public void DeveSomarDezComCincoEResultadoDeveSerQuinze()
        {
            var target = new Calculadora();

            decimal expected = 15;
            decimal actual = 0;

            actual = target.Somar(10, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeveSomarVinteComQuinzeEResultadoDeveSerTrintaECinco()
        {
            var target = new Calculadora();

            decimal expected = 35;
            decimal actual = 0;

            actual = target.Somar(20, 15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeveSubtrairOnzeDeVinteEResultadoDeveSerNove()
        {
            var target = new Calculadora();

            decimal expected = 9;
            decimal actual = 0;

            actual = target.Subtrair(20, 11);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeveSubtrairTresDeSeteEResultadoDeveSerQuatro()
        {
            var target = new Calculadora();

            decimal expected = 4;
            decimal actual = 0;

            actual = target.Subtrair(7, 3);

            Assert.AreEqual(expected, actual);
        }

    }
}
