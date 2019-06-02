﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe para ler uma lista de um arquivo.
    /// </summary>
    public class LeitorDeLista
    {
        private string nomeDoArquivo;

        /// <summary>
        /// Construtor para a classe LeitorDeLista.
        /// </summary>
        /// <param name="nomeDoArquivo">Nome do arquivo de onde a lista
        /// será lida
        /// </param>
        public LeitorDeLista(string nomeDoArquivo)
        {
            this.nomeDoArquivo = nomeDoArquivo;
        }

        /// <summary>
        /// Lê uma lista de um arquivo.
        /// </summary>
        /// <typeparam name="T">Tipo dos elementos a serem lidos.</typeparam>
        /// <returns>Um array contendo os elementos lidos.</returns>
        public T[] Ler<T>()
        {
            using (StreamReader sr = new StreamReader(this.nomeDoArquivo))
            {
                List<T> elementos = new List<T>();

                while (!sr.EndOfStream)
                {
                    T elemento = (T)Convert.ChangeType(sr.ReadLine(), typeof(T));
                    elementos.Add(elemento);
                }

                return elementos.ToArray();
            }
        }
    }
}
