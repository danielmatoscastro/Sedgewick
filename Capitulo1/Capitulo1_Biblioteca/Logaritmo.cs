using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para o cálculo de logaritmos.
    /// </summary>
    public class Logaritmo
    {

        /// <summary>
        /// Calcula o piso do logaritmo na base 2 do número informado.
        /// </summary>
        /// <param name="N">Número cujo logaritmo será calculado.</param>
        /// <returns>Piso do logaritmo na base 2 do valor informado.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Lançada se o argumento informado é menor ou igual a zero.</exception>
        public static int Lg(int N)
        {
            if (N <= 0) throw new ArgumentOutOfRangeException("N", "O argumento deve ser maior que zero.");

            int expoente = 0;
            int aproximacao = 1;

            while (aproximacao * 2 <= N)
            {
                aproximacao *= 2;
                expoente++;
            }

            return expoente;
        }

        /// <summary>
        /// Calcula o logaritmo natural de N!.
        /// </summary>
        /// <param name="N">Número cujo ln(N!) será calculado.</param>
        /// <returns>Logaritmo natural de N!.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Lançada quando o argumento é negativo.</exception>
        public static double LnFatorial(int N)
        {
            if (N < 0) throw new ArgumentOutOfRangeException("N", "O argumento deve ser não negativo.");

            if (N == 0)
            {
                return 0;
            }

            return Math.Log(N) + LnFatorial(N - 1);
        }
    }
}
