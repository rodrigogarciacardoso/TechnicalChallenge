using Aplicacao.Programs;
using Desafio.Interfaces;
using Desafio.Operacoes;
using Microsoft.Extensions.DependencyInjection;

namespace Aplicacao
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
