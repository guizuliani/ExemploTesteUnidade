using System;

namespace ExemploTesteUnidade
{
    public class Calculadora
    {

        public decimal Somar(decimal primeiroValor, decimal segundoValor)
        {
            return primeiroValor + segundoValor;
        }

        public decimal Subtrair(decimal primeiroValor, decimal segundoValor)
        {
            return primeiroValor - segundoValor;
        }

        public decimal Multiplicar(decimal primeiroValor, decimal segundoValor)
        {
            return primeiroValor * segundoValor;
        }

        public decimal Dividir(decimal primeiroValor, decimal segundoValor)
        {
            if (segundoValor == 0)
                throw new ArgumentException("Valor do parâmetro inválido.", "segundoValor");

            return primeiroValor / segundoValor;
        }

    }
}
