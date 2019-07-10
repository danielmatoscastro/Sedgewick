using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para manipulação de vetores.
    /// </summary>
    public class Vetor
    {

        /// <summary>
        /// Remove elementos duplicados em um vetor.
        /// </summary>
        /// <typeparam name="T">Tipo dos elementos do vetor.</typeparam>
        /// <param name="elementos">Vetor cujos elementos duplicados serão
        /// removidos.
        /// </param>
        /// <returns>Novo vetor sem elementos duplicados.</returns>
        public static T[] RemoveDuplicatas<T>(T[] elementos)
        {
            T[] novoVetor = new T[elementos.Length];

            novoVetor[0] = elementos[0];
            int unicos = 1;

            for (int i = 1; i < elementos.Length; i++)
            {
                if (!elementos[i].Equals(elementos[i - 1]))
                {
                    novoVetor[unicos] = elementos[i];
                    unicos++;
                }
            }

            Array.Resize<T>(ref novoVetor, unicos);

            return novoVetor;
        } 
        
        
    }
}
