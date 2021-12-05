using Challenge.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace Challenge.Tests
{
    public class OperacoesTests
    {
        [Fact]
        public void Operacoes_RetornarDivisores_RetornaDivisoresNumero()
        {
            // Arrange
            var decomposicao = new Decomposicao();
            var validarPrimos = new ValidarPrimos();
            var operacoes = new Operacoes.Operacoes(decomposicao, validarPrimos);

            // Act
            var resultado = operacoes.RetornarDivisores(45);

            // Assert
            Assert.Equal(new HashSet<int> { 1, 3, 5, 9, 15, 45 }, resultado);
        }

        [Fact]
        public void Operacoes_RetornarDivisores_DeveRetornarArgumentException()
        {
            // Arrange
            var decomposicao = new Decomposicao();
            var validarPrimos = new ValidarPrimos();
            var operacoes = new Operacoes.Operacoes(decomposicao, validarPrimos);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => operacoes.RetornarDivisores(0));
        }

        [Fact]
        public void Operacoes_RetornarPrimos_RetornaPrimosDeLista()
        {
            // Arrange
            var decomposicao = new Decomposicao();
            var validarPrimos = new ValidarPrimos();
            var operacoes = new Operacoes.Operacoes(decomposicao, validarPrimos);

            // Act
            var resultado = operacoes.RetornarPrimos(new HashSet<int> { 1, 3, 5, 9, 15, 45 });

            // Assert
            Assert.Equal(new HashSet<int> { 1, 3, 5 }, resultado);
        }

        [Fact]
        public void Operacoes_RetornarPrimos_DeveRetornarArgumentException()
        {
            // Arrange
            var decomposicao = new Decomposicao();
            var validarPrimos = new ValidarPrimos();
            var operacoes = new Operacoes.Operacoes(decomposicao, validarPrimos);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => operacoes.RetornarPrimos(new HashSet<int> { }));
        }
    }
}
