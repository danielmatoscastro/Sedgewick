using System.Collections;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa uma pilha implementada
    /// com um array de tamanho dinâmico.
    /// </summary>
    public class PilhaArrayDinamico<Item> : IEnumerable
    {
        private Item[] a;
        private int N;

        public PilhaArrayDinamico<Item>()
        {
            a = new Item[1];
            N = 0;
        }
    }
}