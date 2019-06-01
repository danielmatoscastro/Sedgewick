using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para o cálculo de histograma.
    /// </summary>
    public class Histograma
    {
        /// <summary>
        /// Recebe uma amostra de inteiros e um valor limite M.
        /// Retorna o histograma dessa amostra, para valores entre 0 e M-1.
        /// </summary>
        /// <param name="a">Amostra</param>
        /// <param name="M">Valor limite</param>
        /// <returns>Histograma da amostra a, considerando valores entre 0 e M-1</returns>
        /// <exception cref="ArgumentOutOfRangeException">Lançada quando M é negativo ou zero.</exception>
        public static int[] GetHistograma(int[] a, int M)
        {
            if (M <= 0) throw new ArgumentOutOfRangeException("M", "O argumento M deve ser positivo.");

            int[] histograma = new int[M];

            foreach (int elemento in a)
            {
                if (0 <= elemento && elemento < M)
                {
                    histograma[elemento]++;
                }
            }

            return histograma;
        }
    }
}
