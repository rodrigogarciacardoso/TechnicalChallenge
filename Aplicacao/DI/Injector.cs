using Desafio.Classes;
using Desafio.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Aplicacao.DI
{
    public class Injector
    {
        public static void Configure(ServiceCollection services)
        {
            services.AddSingleton<IDecomposicao, Decomposicao>();
            services.AddSingleton<IValidarPrimos, ValidarPrimos>();
        }
    }
}
