using Application.Programs;
using Challenge.Interfaces;
using Challenge.Operacoes;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    class ProgramsFactory
    {
        private readonly ServiceProvider _serviceProvider;

        public ProgramsFactory(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void BuildPrograms()
        {
            var _decomposicao = _serviceProvider.GetService<IDecomposicao>();
            var _validarPrimos = _serviceProvider.GetService<IValidarPrimos>();
            var operacoes = new Operacoes(_decomposicao, _validarPrimos);

            new DecomposicaoNumericaProgram(operacoes).IniciarDecomposicaoNumerica();
        }
    }
}
