using Desafio.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace Desafio.Tests
{
    public class ValidarPrimosTests
    {
        [Fact]
        public void ValidarPrimos_RetornarPrimos_ValidarPrimosLista()
        {
            // Arrange
            var validarPrimos = new ValidarPrimos();

            // Act
            var resultado = validarPrimos.RetornarPrimos(new HashSet<int> { 1, 3, 5, 9, 15, 45 });

            // Assert
            Assert.Equal(new HashSet<int> { 1, 3, 5 }, resultado);
        }

        [Fact]
        public void ValidarPrimos_RetornarPrimos_DeveRetornarArgumentException()
        {
            // Arrange
            var validarPrimos = new ValidarPrimos();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => validarPrimos.RetornarPrimos(new HashSet<int> { }));
        }
    }
}
