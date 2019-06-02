using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe para escrever uma lista de elementos em um arquivo.
    /// </summary>
    public class EscritorDeLista
    {
        private string nomeDoArquivo;

        /// <summary>
        /// Construtor para a classe EscritorDeLista.
        /// </summary>
        /// <param name="nomeDoArquivo">Nome do arquivo em que a lista 
        /// será escrita.
        /// </param>
        public EscritorDeLista(string nomeDoArquivo)
        {
            this.nomeDoArquivo = nomeDoArquivo;
        }


        /// <summary>
        /// Escreve um array em um arquivo.
        /// </summary>
        /// <typeparam name="T">Tipo dos elementos do array.</typeparam>
        /// <param name="elementos">Array a ser escrito no arquivo.</param>
        public void Escrever<T>(T[] elementos)
        {
            using(StreamWriter sw = new StreamWriter(this.nomeDoArquivo))
            {
                foreach (T elemento in elementos)
                {
                    sw.WriteLine(elemento.ToString());
                }
            }
        }
    }
}
