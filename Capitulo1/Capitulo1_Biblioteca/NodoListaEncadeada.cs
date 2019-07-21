namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa um nodo de uma lista simplesmente encadeada.
    /// </summary>
    /// <typeparam name="Item">Tipo dos elementos a serem armazenados na lista;</typeparam>
    public class NodoListaEncadeada<Item>
    {
        /// <summary>
        /// Item armazenado.
        /// </summary>
        public Item item;
        
        /// <summary>
        /// Proximo nodo da lista.
        /// </summary>
        public NodoListaEncadeada<Item> proximo;
    }
}