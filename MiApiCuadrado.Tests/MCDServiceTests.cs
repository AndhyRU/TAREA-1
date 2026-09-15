using Xunit;
using MiApiCuadrado.Services;       

namespace MiApiCuadrado.Test
{
    public class MCDServiceTests
    {
        [Theory]
        [InlineData(48, 18, 6)]
        [InlineData(100, 25, 25)]
        [InlineData(20, 8, 4)]
        [InlineData(17, 5, 1)]
        public void CalcularMCD_ConNumerosValidos_RetornaMCDEsperado(
            int dividendo,
            int divisor,
            int esperado)
        {
            // Arrange
            var sut = new MCDService();

            // Act
            int resultado = sut.CalcularMCD(dividendo, divisor);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void CalcularMCD_CuandoDivisorEsCero_RetornaDividendo()
        {
            // Arrange
            var sut = new MCDService();

            int dividendo = 25;
            int divisor = 0;

            // Act
            int resultado = sut.CalcularMCD(dividendo, divisor);

            // Assert
            Assert.Equal(25, resultado);
        }
    }
}


