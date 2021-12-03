using Desafio.Interfaces;
using System;
using System.Collections.Generic;

namespace Desafio.Classes
{
    public class Decomposicao : IDecomposicao
    {
        public Decomposicao()
        { }

        public HashSet<int> RetornaDivisores(int numero)
        {
            if (numero == 0)
            {
                throw new ArgumentException();
            }

            var divisores = new HashSet<int>();

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores.Add(i);
                }
            }

            return divisores;
        }
    }
}
