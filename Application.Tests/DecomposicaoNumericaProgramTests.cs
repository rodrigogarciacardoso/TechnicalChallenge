using Application.Programs;
using Challenge.Classes;
using Challenge.Operacoes;
using System;
using System.IO;
using Xunit;

namespace Application.Tests
{
    public class DecomposicaoNumericaProgramTests
    {
        [Fact]
        public void DecomposicaoNumericaProgram_IniciarDecomposicaoNumerica_ReceberValorEfetuarDecomposicaoEValidarPrimos()
        {
            // Arrange
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("45");
            Console.SetIn(input);

            var decomposicao = new Decomposicao();
            var validarPrimos = new ValidarPrimos();
            var decomposicaoNumericaProgram = new DecomposicaoNumericaProgram(new Operacoes(decomposicao, validarPrimos));

            var expectedOutput = "Digite um número: \nNúmero de Entrada: 45\r\nNúmeros divisores: 1 3 5 9 15 45\r\nDivisores Primos: 1 3 5\r\n\n\nDigite um número: \n";

            // Act
            decomposicaoNumericaProgram.IniciarDecomposicaoNumerica();

            // Assert
            Assert.Equal(expectedOutput, output.ToString());
        }

        [Fact]
        public void DecomposicaoNumericaProgram_LerEntrada_SomenteNumerosPositivos()
        {
            // Arrange
            var input = new StringReader("-1");
            Console.SetIn(input);

            var decomposicao = new Decomposicao();
            var validarPrimos = new ValidarPrimos();
            var decomposicaoNumericaProgram = new DecomposicaoNumericaProgram(new Operacoes(decomposicao, validarPrimos));

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => decomposicaoNumericaProgram.IniciarDecomposicaoNumerica());
        }
    }
}
