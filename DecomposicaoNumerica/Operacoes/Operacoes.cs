using Desafio.Interfaces;
using System.Collections.Generic;

namespace Desafio.Operacoes
{
    public class Operacoes
    {
        private readonly IDecomposicao _decomposicao;
        private readonly IValidarPrimos _validaPrimos;

        public Operacoes(IDecomposicao decomposicao, IValidarPrimos validaPrimos)
        {
            _decomposicao = decomposicao;
            _validaPrimos = validaPrimos;
        }

        public HashSet<int> RetornarDivisores(int entrada)
        {            
            return _decomposicao.RetornaDivisores(entrada);
        }

        public HashSet<int> RetornarPrimos(HashSet<int> numeros)
        {
            return _validaPrimos.RetornarPrimos(numeros);
        }
    }
}
