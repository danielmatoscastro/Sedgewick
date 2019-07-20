namespace Capitulo1_Biblioteca
{
    
    /// <summary>
    /// Classe que representa uma pilha de strings de tamanho fixo.
    /// </summary>
    public class PilhaDeStringsTamanhoFixo
    {
        private string[] a;
        private int N;

        /// <summary>
        /// Indica se a pilha está vazia.
        /// </summary>
        public bool EstaVazia
        {
            get
            { return N == 0; }
        }

        /// <summary>
        /// Indica se a pilha está cheia.
        /// </summary>
        public bool EstaCheia
        {
            get { return N == a.Length; }
        }

        /// <summary>
        /// Retorna a quantidade de itens na pilha.
        /// </summary>
        public int Tamanho
        {
            get { return N; }
        }
        
        /// <summary>
        /// Objeto que representa uma pilha de strings de tamanho fixo.
        /// </summary>
        /// <param name="cap">Tamanho máximo da pilha.</param>
        public PilhaDeStringsTamanhoFixo(int cap)
        {
            a = new string[cap];
        }

        /// <summary>
        /// Insere uma string na pilha.
        /// </summary>
        /// <param name="item">String a ser empilhada.</param>
        public void Push(string item)
        {
            a[N++] = item;
        }

        /// <summary>
        /// Remove um elemento do topo da pilha.
        /// </summary>
        /// <returns>Elemento removido da pilha.</returns>
        public string Pop()
        {
            return a[--N];
        }
    }
}