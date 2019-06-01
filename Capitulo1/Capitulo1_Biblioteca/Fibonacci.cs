using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para o cálculo da sequência de Fibonacci.
    /// </summary>
    public class Fibonacci
    {
        private static long[] buffer;

        /// <summary>
        /// Calcula recursivamente o enésimo termo da sequência de Fibonacci.
        /// </summary>
        /// <param name="n">Número do termo a ser calculado.</param>
        /// <returns>Enésimo termo da sequência de Fibonacci.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Lançada quando o argumento é negativo.</exception>
        public static long F(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("n", "O argumento deve ser não negativo.");

            if (n == 0) return 0;
            if (n == 1) return 1;

            return F(n - 1) + F(n - 2);
        }

        /// <summary>
        /// Calcula o enésimo termo da sequência de Fibonacci usando programação dinâmica.
        /// </summary>
        /// <param name="n">Número do termo a ser calculado.</param>
        /// <returns>Enésimo termo da sequência de Fibonacci.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Lançada quando o argumento é negativo.</exception>
        public static long FProgramacaoDinamica(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("n", "O argumento deve ser não negativo.");
           
            ChecarBuffer(n);

            buffer[0] = 0;
            buffer[1] = 1;

            for (int i = 2; i < n; i++)
            {
                buffer[i] = buffer[i - 1] + buffer[i - 2];
            }

            return buffer[n - 1] + buffer[n - 2];
        }

        private static void ChecarBuffer(int n)
        {
            if (buffer == null)
            {
                buffer = new long[n];
            }
            else
            {
                if (buffer.Length < n)
                {
                    RedimensionaBuffer(n);
                }
            }
        }

        private static void RedimensionaBuffer(int n)
        {
            long[] novoBuffer = new long[n];

            for (int i = 0; i < buffer.Length; i++)
            {
                novoBuffer[i] = buffer[i];
            }

            buffer = novoBuffer;
        }
    }
}
