using Challenge.Operacoes;
using System;

namespace Aplicacao.Programs
{
    public class DecomposicaoNumericaProgram
    {
        private readonly Operacoes _operacoes;

        public DecomposicaoNumericaProgram(Operacoes operacoes)
        {
            _operacoes = operacoes;
        }

        public void IniciarDecomposicaoNumerica()
        {
            int entrada = 0;

            while (true)
            {
                Console.Write("Digite um número: ");
                entrada = LerEntrada();
                Console.Write("\n");

                if (entrada == 0)
                    break;

                var divisores = _operacoes.RetornarDivisores(entrada);
                var primos = _operacoes.RetornarPrimos(divisores);

                Console.WriteLine($"Número de Entrada: {entrada}");
                Console.WriteLine($"Números divisores: {string.Join(" ", divisores)}");
                Console.WriteLine($"Divisores Primos: {string.Join(" ", primos)}");

                Console.Write("\n"); Console.Write("\n");
            }
        }

        private int LerEntrada()
        {
            string strEntrada = Console.ReadLine();
            int.TryParse(strEntrada, out int entrada);

            return entrada;
        }
    }
}
