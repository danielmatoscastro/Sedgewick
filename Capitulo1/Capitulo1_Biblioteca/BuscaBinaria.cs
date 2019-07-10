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
                
                if (arr[mid] < key)
                {
                    lo = mid + 1;
                }
                else
                { 
                    hi = mid - 1;
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

        /// <summary>
        /// Conta quantos elementos do vetor ordenado arr são menores que key.
        /// </summary>
        /// <param name="key">Elemento a ser buscado.</param>
        /// <param name="arr">Espaço de busca.</param>
        /// <returns>Quantidade de elementos menores que key no vetor arr.</returns>
        public static int RankMenores(int key, int[] arr)
        {
            return RankMenores(key, arr, 0, arr.Length);
        }

        /// <summary>
        /// Busca pela posição que o elemento key deveria ocupar no array.
        /// Baseado no algoritmo presente em https://www.ime.usp.br/~pf/analise_de_algoritmos/aulas/binarysearch.html
        /// </summary>
        /// <param name="key">Elemento a ser buscado.</param>
        /// <param name="arr">Espaço de busca.</param>
        /// <param name="lo">Menor índice do vetor.</param>
        /// <param name="hiPlus1">Quantidade de elementos no vetor.</param>
        /// <returns>Retorna a posição i do vetor arr tal que arr[i-1] &lt; key &lt;= arr[i].</returns>
        private static int RankMenores(int key, int[] arr, int lo, int hiPlus1)
        {
            if (key <= arr[0])
            {
                return 0;
            }
            
            if (lo == hiPlus1 - 1)
            {
                return hiPlus1;
            }

            int meio = (lo + hiPlus1) / 2;

            if (arr[meio] < key)
            {
                return RankMenores(key, arr, meio, hiPlus1);
            }

            return RankMenores(key, arr, lo, meio);
        }
        
        /// <summary>
        /// Conta quantos elementos do vetor ordenado arr são maiores que key.
        /// </summary>
        /// <param name="key">Elemento a ser buscado.</param>
        /// <param name="arr">Espaço de busca.</param>
        /// <returns>Quantidade de elementos maiores que key no vetor arr.</returns>
        public static int RankMaiores(int key, int[] arr)
        {
            return arr.Length - RankMaiores(key, arr, -1, arr.Length-1);
        }
        
        /// <summary>
        /// Busca pela posição que o elemento key deveria ocupar no array.
        /// Baseado no algoritmo presente em https://www.ime.usp.br/~pf/analise_de_algoritmos/aulas/binarysearch.html
        /// </summary>
        /// <param name="key">Elemento a ser buscado.</param>
        /// <param name="arr">Espaço de busca.</param>
        /// <param name="loMinus1">Menor índice do vetor menos 1.</param>
        /// <param name="hi">Maior índice do vetor.</param>
        /// <returns>Retorna a posição i do vetor arr tal que arr[i-1] &lt;= key &lt; arr[i].</returns>
        private static int RankMaiores(int key, int[] arr, int loMinus1, int hi)
        {
            if (arr[hi] <= key)
            {
                return hi+1;
            }

            if (arr[loMinus1+1] > key)
            {
                return loMinus1 + 1;
            }
            
            if (loMinus1+1 == hi)
            {
                return hi;
            }
            
            int meio = (loMinus1 + hi) / 2;

            if (arr[meio] > key)
            {
                return RankMaiores(key, arr, loMinus1, meio);
            }

            return RankMaiores(key, arr, meio, hi);
        }

        /// <summary>
        /// Conta quantos elementos no vetor ordenado são iguais a key.
        /// </summary>
        /// <param name="key">Elementado a ser contado.</param>
        /// <param name="arr">Espaço de busca.</param>
        /// <returns>Quantidade de elementos iguais a key.</returns>
        public static int Count(int key, int[] arr)
        {
            return arr.Length - RankMaiores(key, arr) - RankMenores(key, arr);
        }
        
    }
}
