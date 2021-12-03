using System;
using System.Collections.Generic;

namespace Aplicacao
{
    class Program
    {
        static void Main()
        {
            var divisores = new HashSet<int>();
            var primos = new HashSet<int>();

            Console.Write("Digite um número: ");
            string strEntrada = Console.ReadLine();
            Console.Write("\n");

            int.TryParse(strEntrada, out int entrada);

            for (int i = 1; i <= entrada; i++)
            {
                if (entrada % i == 0)
                {
                    divisores.Add(i);
                }
            }

            var isPrimo = true;
            foreach (var item in divisores)
            {
                for (int i = 0; i <= item; i++)
                {
                    if ((i == 0) || (i == item) || (i == 1))
                    {
                        continue;
                    }

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

            Console.WriteLine($"Número de Entrada: {entrada}");
            Console.WriteLine($"Números divisores: {string.Join(" ", divisores)}");
            Console.WriteLine($"Divisores Primos: {string.Join(" ", primos)}");
        }
    }
}

