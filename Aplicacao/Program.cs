using Aplicacao.DI;
using Microsoft.Extensions.DependencyInjection;

namespace Aplicacao
{
    class Program
    {
        static void Main()
        {
            var _service = new ServiceCollection();
            Injector.Configure(_service);
            var _serviceProvider = _service.BuildServiceProvider();

            new ProgramsFactory(_serviceProvider).BuildPrograms();
        }
    }
}

