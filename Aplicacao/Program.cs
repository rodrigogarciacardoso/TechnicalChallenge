using Aplicacao.DI;
using Desafio.Interfaces;
using Desafio.Operacoes;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Aplicacao
{
    class Program
    {
        static void Main()
        {
            var _service = new ServiceCollection();
            Injector.Configure(_service);
            var _serviceProvider = _service.BuildServiceProvider();

            int entrada = 0;
            do
            {

                Console.Write("Digite um número: ");
                string strEntrada = Console.ReadLine();
                Console.Write("\n");
                int.TryParse(strEntrada, out entrada);

                if (entrada != 0)
                {
                    var _decomposicao = _serviceProvider.GetService<IDecomposicao>();
                    var _validarPrimos = _serviceProvider.GetService<IValidarPrimos>();

                    var operacoes = new Operacoes(_decomposicao, _validarPrimos);

                    var divisores = operacoes.RetornarDivisores(entrada);
                    var primos = operacoes.RetornarPrimos(divisores);

                    Console.WriteLine($"Número de Entrada: {entrada}");
                    Console.WriteLine($"Números divisores: {string.Join(" ", divisores)}");
                    Console.WriteLine($"Divisores Primos: {string.Join(" ", primos)}");

                    Console.Write("\n"); Console.Write("\n"); Console.Write("\n");
                }

            } while (entrada != 0);
        }
    }
}

