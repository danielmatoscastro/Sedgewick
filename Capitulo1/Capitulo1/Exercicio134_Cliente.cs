using System;
using System.Collections.Generic;
using System.Linq;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.3.4.
    /// </summary>
    public class Exercicio134_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com a sequência de parênteses separada por espaços.");
                string[] parenteses = Console.ReadLine().Trim().Split(new[] {' '}, 
                    StringSplitOptions.RemoveEmptyEntries);

                if (ValidaExpressao(parenteses))
                { 
                    Console.WriteLine("Expressão é válida.");   
                }
                else
                {
                    Console.WriteLine("Expressão não é válida.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        private static bool ValidaExpressao(string[] parenteses)
        {
            Dictionary<string, string> tradutor = new Dictionary<string, string>();
            tradutor.Add("(", ")");
            tradutor.Add("[", "]");
            tradutor.Add("{", "}");
            
            Pilha<string> pilha = new Pilha<string>();

            foreach (string parentese in parenteses)
            {
                if (tradutor.Keys.Contains(parentese))
                {
                    pilha.Push(parentese);
                }
                else
                {
                    if (pilha.EstaVazia)
                    {
                        return false;
                    }
                    
                    string parenteseEsperado = tradutor[pilha.Pop()];
                    
                    if (!parenteseEsperado.Equals(parentese))
                    {
                        return false;
                    }
                }
            }

            return pilha.EstaVazia;
        }
    }
}