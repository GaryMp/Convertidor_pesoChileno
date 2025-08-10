using ConversorDeMoneda1;
using Xunit;

namespace Conversion.Tests
{
    public class ConversionTests
    {
        [Fact]
        public void ConvierteValorConocido()
        {
            bool ok = Convertidor.TryConvertir("100", out double resultado);
            Assert.True(ok);
            Assert.Equal(2.3, resultado, 3);
        }

        [Fact]
        public void ManejaEntradaNoNumericaSinExcepciones()
        {
            var ex = Record.Exception(() => Convertidor.TryConvertir("abc", out double resultado));
            Assert.Null(ex);
            Assert.False(Convertidor.TryConvertir("abc", out _));
        }
    }
}
