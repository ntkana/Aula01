using Aula01.Classes;

namespace Aula01.Test
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar_DeveRetornarResultadoSomaCorreto()
        {
            Calculadora calc = new Calculadora(5, 5);

            double resultado = calc.Somar();

            Assert.Equal(10, resultado);

        }

        [Fact]
        public void Subtrair_DeveRetornarResultadoSubtracaoCorreto()
        {
            Calculadora calc = new Calculadora(20, 10);

            double resultado = calc.Subtrair();

            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Multiplicar_DeveRetornarResultadoMultiplicacaoCorreto()
        {
            Calculadora calc = new Calculadora(5, 5);
            double resultado = calc.Multiplicar();
            Assert.Equal(25, resultado);
        }

        [Fact]
        public void Dividir_DeveRetornarResultadoDivisaoCorreto()
        {
            Calculadora calc = new Calculadora(10, 5);
            double resultado = calc.Dividir();
            Assert.Equal(2, resultado);
        }
    }
}
