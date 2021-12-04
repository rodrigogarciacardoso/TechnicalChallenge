using Desafio.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace Desafio.Tests
{
    public class DecomposicaoTests
    {
        [Fact]
        public void Decomposicao_RetornaDivisores_RetornarDivisoresDeUmNumero()
        {
            // Arrange
            var decomposicao = new Decomposicao();

            // Act
            var resultado = decomposicao.RetornaDivisores(45);

            // Assert
            Assert.Equal(new HashSet<int> { 1, 3, 5, 9, 15, 45 }, resultado);
        }

        [Fact]
        public void Decomposicao_RetornaDivisore_DeveRetornarArgumentException()
        {
            // Arrange
            var decomposicao = new Decomposicao();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => decomposicao.RetornaDivisores(0));
        }
    }
}
