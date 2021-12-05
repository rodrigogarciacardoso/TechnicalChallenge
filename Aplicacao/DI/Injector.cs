using Challenge.Classes;
using Challenge.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DI
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
