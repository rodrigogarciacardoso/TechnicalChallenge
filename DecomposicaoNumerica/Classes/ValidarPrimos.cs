using Desafio.Interfaces;
using System;
using System.Collections.Generic;

namespace Desafio.Classes
{
    public class ValidarPrimos : IValidarPrimos
    {
        public ValidarPrimos()
        { }

        public HashSet<int> RetornarPrimos(HashSet<int> _entrada)
        {
            var isPrimo = true;
            var primos = new HashSet<int>();

            foreach (var item in _entrada)
            {
                for (int i = 2; i <= Math.Sqrt(item); i++)
                {
                    if (item % i == 0)
                    {
                        isPrimo = false;
                        break;
                    }
                }

                if (isPrimo)
                {
                    primos.Add(item);
                    isPrimo = true;
                }
            }

            return primos;
        }
    }
}
