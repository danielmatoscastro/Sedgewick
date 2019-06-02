using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para a geração de números aleatórios.
    /// </summary>
    public class GeradorAleatorio
    {
        /// <summary>
        /// Gera um array de inteiros aleatórios.
        /// </summary>
        /// <param name="n">Quantidade de números a serem gerados.</param>
        /// <param name="lo">Limite inferior (incluso) da amostra.</param>
        /// <param name="hi">Limite superior (incluso) da amostra.</param>
        /// <returns>Array de´inteiros aleatórios no intervalo [lo, hi] </returns>
        public static int[] GerarInteiros(int n, int lo, int hi)
        {
            int[] numeros = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                numeros[i] = random.Next(lo, hi + 1);
            }

            return numeros;
        }
    }
}
