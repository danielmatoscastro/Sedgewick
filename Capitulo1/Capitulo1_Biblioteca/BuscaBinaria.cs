using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para realização de busca binária.
    /// </summary>
    public class BuscaBinaria
    { 

        /// <summary>
        /// Realiza busca binária iterativa no array informado, buscando pelo
        /// elemento key.
        /// </summary>
        /// <param name="key">Elemento a ser buscado.</param>
        /// <param name="arr">Espaço de busca.</param>
        /// <returns>Retorna a posição do elemento key, ou -1 caso
        /// o elemento não esteja no array.
        /// </returns>
        public static int Rank(int key, int[] arr)
        {
            return Rank(key, arr, 0, arr.Length - 1);
        }

        private static int Rank(int key, int[] arr, int lo, int hi)
        {
            while (lo <= hi)
            {
                int mid = ((hi - lo) / 2) + lo;

                if (arr[mid] == key)
                {
                    return mid;
                }
                else
                {
                    if (arr[mid] < key)
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid - 1;
                    }
                }

            }

            return -1;
        }

        /// <summary>
        /// Realiza busca binária recursiva no array informado, buscando pelo
        /// elemento key.
        /// </summary>
        /// <param name="key">Elemento a ser buscado.</param>
        /// <param name="arr">Espaço de busca.</param>
        /// <returns>Retorna a posição do elemento key, ou -1 caso
        /// o elemento não esteja no array.
        /// </returns>
        public static int RankRecursivo(int key, int[] arr)
        {
            return RankRecursivo(key, arr, 0, arr.Length);
        }
 
        private static int RankRecursivo(int key, int[] arr, int lo, int hi)
        {
            if (lo > hi)
            {
                return -1;
            }

            int mid = ((hi - lo) / 2) + lo;

            if (arr[mid] == key)
            {
                return mid;
            }
            else
            {
                if (arr[mid] < key)
                {
                    return RankRecursivo(key, arr, mid + 1, hi);
                }
                else
                {
                    return RankRecursivo(key, arr, lo, mid = 1);
                }
            }
            
        }

        /// <summary>
        /// Realiza busca binária recursiva no array informado, buscando pelo
        /// elemento key. Realiza um rastreamento das chamadas recursivas.
        /// </summary>
        /// <param name="key">Elemento a ser buscado.</param>
        /// <param name="arr">Espaço de busca.</param>
        /// <returns>Tupla contendo o rastreador e o resultado da busca
        /// (nessa ordem).
        /// </returns>
        public static Tuple<StringBuilder, int> RankRecursivoComRastreio(int key, int[] arr)
        {
            StringBuilder sb = new StringBuilder();

            int indice = RankRecursivo(key, arr, 0, arr.Length - 1, 1, sb);

            return new Tuple<StringBuilder, int>(sb, indice);
        }

        private static int RankRecursivo(int key, int[] arr, int lo, int hi, int profundidade, StringBuilder sb)
        {
            sb.Append("".PadLeft(profundidade, ' '));
            sb.Append(String.Format("lo: {0} | hi: {1}\n", lo, hi));

            if (lo > hi)
            {
                return -1;
            }

            int mid = ((hi - lo) / 2) + lo;

            if (arr[mid] == key)
            {
                return mid;
            }
            else
            {
                if (arr[mid] < key)
                {
                    return RankRecursivo(key, arr, mid + 1, hi, profundidade + 1, sb);
                }
                else
                {
                    return RankRecursivo(key, arr, lo, mid = 1, profundidade + 1, sb);
                }
            }
        } 

    }
}
