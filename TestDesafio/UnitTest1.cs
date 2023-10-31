using Desafio;
using System;
using Xunit;

namespace TestDesafio
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(1,5,6)]
        public void TestSomar(int val1,int val2,int res)
        {
            //AAA
            var calc = new Calculadora();

            //ACT
            int resultadoCalculadora = calc.somar(val1,val2);

            //ASSERT
            Assert.Equal(res,resultadoCalculadora);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int res)
        {
            //AAA
            var calc = new Calculadora();

            //ACT
            int resultadoCalculadora = calc.multiplicar(val1, val2);

            //ASSERT
            Assert.Equal(res, resultadoCalculadora);
        }
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 2, 3)]
        public void TestSubtrair(int val1, int val2, int res)
        {
            //AAA
            var calc = new Calculadora();

            //ACT
            int resultadoCalculadora = calc.subtrair(val1, val2);

            //ASSERT
            Assert.Equal(res, resultadoCalculadora);
        }
        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(6, 3, 2)]
        public void TestDividir(int val1, int val2, int res)
        {
            //AAA
            var calc = new Calculadora();

            //ACT
            int resultadoCalculadora = calc.dividir(val1, val2);

            //ASSERT
            Assert.Equal(res, resultadoCalculadora);
        }
        [Fact]
        public void TestarDivisaoPorZero()
        {
            var calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }
        [Fact]
        public void TestarHistorico()
        {
            var calc = new Calculadora();

            calc.somar(4, 2);
            calc.somar(4, 9);
            calc.somar(6, 2);
            calc.somar(5, 2);

            var lista = calc.historico();
            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);

        }
    }
}
