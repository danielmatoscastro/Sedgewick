using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.3.1.
    /// </summary>
    public class Exercicio131_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o número de strings: ");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lendo {0} linhas: ", N);
                
                PilhaDeStringsTamanhoFixo pilha = new PilhaDeStringsTamanhoFixo(N);
                while (!pilha.EstaCheia)
                {
                    pilha.Push(Console.ReadLine());
                }
                
                Console.WriteLine("Apresentando as linhas lidas: ");
                while (!pilha.EstaVazia)
                {
                    Console.WriteLine(pilha.Pop());
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
    }
}