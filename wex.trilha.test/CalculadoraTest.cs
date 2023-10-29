using wex.trilha.console;
using Xunit;

namespace wex.trilha.test
{
    public class CalculadoraTest
    {
        private Calculadora _calculadora = new Calculadora();

        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(10, 5, 15)]
        [InlineData(0, 5, 5)]
        public void Somar(double a, double b, double x)
        {
            double resultado = _calculadora.Adicao(a, b);
            Assert.Equal(x, resultado);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(10, 5, 5)]
        [InlineData(0, 5, -5)]
        public void Subtrair(double a, double b, double x)
        {
            double resultado = _calculadora.Subtracao(a, b);
            Assert.Equal(x, resultado);
        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(10, 5, 50)]
        [InlineData(0, 5, 0)]
        public void Multiplicar(double a, double b, double x)
        {
            double resultado = _calculadora.Multiplicacao(a, b);
            Assert.Equal(x, resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(20, 4, 5)]
        [InlineData(8, 0, double.NaN)]
        public void Dividir(double a, double b, double x)
        {
            double resultado = _calculadora.Divisao(a, b);
            Assert.Equal(x, resultado);
        }

        [Fact]
        public void Historico()
        {

            _calculadora.Adicao(3, 2);
            _calculadora.Subtracao(12, 5);
            _calculadora.Divisao(5, 5);

            Assert.Equal(3, _calculadora.Historico().Count);
        }
    }
}
