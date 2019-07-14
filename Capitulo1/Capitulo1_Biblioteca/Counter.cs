using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa um contador.
    /// </summary>
    public class Counter
    {
        private string id;
        private int tally;

        /// <summary>
        /// Valor do contador.
        /// </summary>
        public int Tally => tally;

        /// <summary>
        /// Objeto que representa um contador.
        /// </summary>
        /// <param name="id">Identificador do contador.</param>
        public Counter(string id)
        {
            this.id = id;
            tally = 0;
        }

        /// <summary>
        /// Incrementa o contador.
        /// </summary>
        public void Increment()
        {
            tally++;
        }

        /// <summary>
        /// Retorna uma representação do contador como string.
        /// </summary>
        /// <returns>String representando o contador.</returns>
        public override string ToString()
        {
            return String.Format("{0} {1}", tally, id);
        }
    }
}