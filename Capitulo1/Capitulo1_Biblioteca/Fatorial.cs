using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que contém métodos estáticos para o cálculo de fatorial.
    /// </summary>
    public class Fatorial
    {
        /// <summary>
        /// Calcula recursivamente o fatorial de um número N.
        /// </summary>
        /// <param name="N">Número cujo fatorial será calculado.</param>
        /// <returns>Fatorial de N.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Lançada quando o argumento é negativo.</exception>
        public static long Fat(int N)
        {
            if (N < 0) throw new ArgumentOutOfRangeException("N", "O argumento deve ser não negativo.");

            if (N == 0)
            {
                return 1;
            }

            return N * Fat(N - 1);
        }
    }
}
