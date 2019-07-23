using System;
using System.Collections;
using System.Collections.Generic;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa uma pilha.
    /// </summary>
    /// <typeparam name="Item">Tipo dos elementos a serem empilhados.</typeparam>
    public class Pilha<Item> : IEnumerable
    {
        private NodoListaEncadeada<Item> primeiro;
        private int N;


        /// <summary>
        /// Retorna o topo da pilha (sem removê-lo).
        /// </summary>
        public Item Topo
        {
            get { return primeiro.item; }
        }
        
        /// <summary>
        /// Indica se a pilha está vazia.
        /// </summary>
        public bool EstaVazia
        {
            get { return primeiro == null; }
        }

        /// <summary>
        /// Retorna o tamanho da pilha;
        /// </summary>
        public int Tamanho
        {
            get { return N; }
        }

        /// <summary>
        /// Coloca um elemento na pilha.
        /// </summary>
        /// <param name="item">Elemento a ser empilhado.</param>
        public void Push(Item item)
        {
            NodoListaEncadeada<Item> antigo = primeiro;
            
            primeiro = new NodoListaEncadeada<Item>();
            primeiro.item = item;
            primeiro.proximo = antigo;
            
            N++;
        }

        /// <summary>
        /// Retira um elemento da pilha.
        /// </summary>
        /// <returns></returns>
        public Item Pop()
        {
            Item item = primeiro.item;
            primeiro = primeiro.proximo;
            N--;

            return item;
        }

        /// <summary>
        /// Produz um iterador para a pilha.
        /// </summary>
        /// <returns>Iterador.</returns>
        public IEnumerator GetEnumerator()
        {
            return new PilhaEnumerator(primeiro);
        } 
        
        /// <summary>
        /// Enumerador da pilha.
        /// </summary>
        private class PilhaEnumerator : IEnumerator
        {
            private bool estaNoInicio;
            private bool estaNoFim;
            private NodoListaEncadeada<Item> nodoAtual;
            private NodoListaEncadeada<Item> primeiro;
            
            /// <summary>
            /// Retorna o elemento atual da pilha.
            /// </summary>
            /// <exception cref="InvalidOperationException">Lançada quando a posição atual é inválida.</exception>
            public object Current
            {
                get
                {
                    if (estaNoInicio || estaNoFim)
                    {
                        throw new InvalidOperationException();
                    }

                    return nodoAtual.item;
                }
            }

            /// <summary>
            /// Objeto que representa um enumerador para a pilha.
            /// </summary>
            /// <param name="primeiro">Primeiro elemento da pilha.</param>
            public PilhaEnumerator(NodoListaEncadeada<Item> primeiro)
            {
                this.primeiro = primeiro;
                estaNoInicio = true;
            }
            
            /// <summary>
            /// Move o iterador para a próxima posição.
            /// </summary>
            /// <returns>True se o iterador foi para uma posição válida.</returns>
            public bool MoveNext()
            {
                if (estaNoInicio)
                {
                    nodoAtual = primeiro;
                    estaNoInicio = false;
                }
                else if (!estaNoFim)
                {
                    nodoAtual = nodoAtual.proximo;
                }
                
                if (nodoAtual == null)
                {
                    estaNoFim = true;
                }

                return !estaNoFim;
            }

            /// <summary>
            /// Retorna o iterador para antes da primeira posição.
            /// </summary>
            public void Reset()
            {
                nodoAtual = primeiro;
                estaNoInicio = true;
            }
        }
    }
}