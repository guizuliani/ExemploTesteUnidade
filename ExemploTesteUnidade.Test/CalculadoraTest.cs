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

    }
}
