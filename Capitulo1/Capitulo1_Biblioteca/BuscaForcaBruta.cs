namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para busca por força bruta.
    /// </summary>
    public class BuscaForcaBruta
    {
        /// <summary>
        /// Busca um elemento em um vetor, utilizando força bruta.
        /// </summary>
        /// <param name="key">Elemento a ser buscado.</param>
        /// <param name="a">Espaço de busca.</param>
        /// <returns>O índice do elemento no vetor, ou -1 caso o elemento não esteja presente.</returns>
        public static int Rank(int key, int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == key)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}