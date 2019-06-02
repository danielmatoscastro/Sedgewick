using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para obter representação como string de arrays.
    /// </summary>
    public class ImpressorVetorial
    {

        /// <summary>
        /// Produz uma representação como string de um array.
        /// </summary>
        /// <typeparam name="T">Tipo dos elementos do array.</typeparam>
        /// <param name="array">Array a ser representado como string.</param>
        /// <returns>Representação como string do array informado.</returns>
        public static string ImprimeArray<T>(T[] array)
        {
            StringBuilder sb = new StringBuilder();

            foreach (T elemento in array)
            {
                sb.Append(elemento.ToString());
                sb.Append(" ");
            }

            return sb.ToString().TrimEnd();
        }

        /// <summary>
        /// Produz uma representação como string de um array.
        /// </summary>
        /// <typeparam name="T">Tipo dos elementos do array.</typeparam>
        /// <param name="array">Array a ser representado como string.</param>
        /// <param name="separador">Separador entre elementos.</param>
        /// <returns>Representação como string do array informado.</returns>
        public static string ImprimeArray<T>(T[] array, string separador)
        {
            StringBuilder sb = new StringBuilder();

            foreach (T elemento in array)
            {
                sb.Append(elemento.ToString());
                sb.Append(separador);
            }

            return sb.ToString().TrimEnd();
        }

        /// <summary>
        /// Produz uma representação como string de um array.
        /// Em cada linha da string retornada, consta um par na seguinte sintaxe:
        /// [indice do array]: [elemento do array]
        /// </summary>
        /// <typeparam name="T">Tipo dos elementos do array.</typeparam>
        /// <param name="array">Array a ser representado como string.</param>
        /// <returns>Representação como string do array informado.</returns>
        public static string ImprimeArrayIndiceValor<T>(T[] array)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(i);
                sb.Append(": ");
                sb.Append(array[i].ToString());
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
