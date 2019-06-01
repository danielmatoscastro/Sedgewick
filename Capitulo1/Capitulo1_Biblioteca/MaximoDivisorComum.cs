using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para o cálculo de M.D.C. (máximo divisor comum).
    /// </summary>
    public class MaximoDivisorComum
    {
        /// <summary>
        /// Calcula o MDC de dois números usando o Algoritmo de Euclides.
        /// </summary>
        /// <param name="p">Primeiro número</param>
        /// <param name="q">Segundo número</param>
        /// <returns>MDC de p e q</returns>
        public static int Mdc(int p, int q)
        {
            if (q == 0)
            {
                return p;
            }

            int r = p % q;

            return Mdc(p, r);
        }

        /// <summary>
        /// Calcula o MDC de dois números usando o Algoritmo de Euclides.
        /// Mantém um rastreio das chamadas recursivas.
        /// </summary>
        /// <param name="p">Primeiro número</param>
        /// <param name="q">Segundo número</param>
        /// <returns>
        /// Tupla contendo o rastreio das chamadas e o MDC (nesta ordem)
        /// </returns>
        public static Tuple<StringBuilder, int> MdcComRastreio(int p, int q)
        {
            StringBuilder rastreio = new StringBuilder();

            int mdc = Mdc(p, q, rastreio);

            return new Tuple<StringBuilder, int>(rastreio, mdc);
        }
        
        private static int Mdc(int p, int q, StringBuilder rastreio)
        {
            rastreio.Append(String.Format("p: {0} || q: {1}\n", p, q));

            if (q == 0)
            {
                return p;
            }

            int r = p % q;

            return Mdc(p, r, rastreio);
        }


    }
}
