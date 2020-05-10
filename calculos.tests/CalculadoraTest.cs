using System;
using Xunit;
using calculos;


namespace calculos.tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Soma_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Soma(10, 20);
            //Verifica se o resultado é igual a 30        
            Assert.Equal(30, resultado);
        }

        [Fact]
        public void Sub_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Subtracao(30, 20);
            //Verifica se o resultado é igual a 30        
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Mul_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Multiplicao(30, 20);
            //Verifica se o resultado é igual a 30        
            Assert.Equal(600, resultado);
        }

         [Fact]
        public void Div_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Divisao(6, 2);
            //Verifica se o resultado é igual a 30        
            Assert.Equal(3, resultado);
        }
    }
}
