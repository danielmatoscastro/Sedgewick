using System;
using System.IO;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.3.2.
    /// </summary>
    public class Exercicio132_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                string[] entradas =
                {
                    "It", "was", "-", "the", "best", "-", "of", "time", "-", "-", "-",
                    "it", "was", "-", "the", "-", "-"
                };
                
                Console.WriteLine("Entrada:");
                Console.WriteLine(ImpressorVetorial.ImprimeArray<string>(entradas));
                Console.WriteLine("Resultado:");
                
                Pilha<string> pilha = new Pilha<string>();

                foreach (string entrada in entradas)
                {
                    if (!"-".Equals(entrada))
                    {
                        pilha.Push(entrada);
                    }else if (!pilha.EstaVazia)
                    {
                        Console.Write("{0} ", pilha.Pop());
                    }
                }
                
                Console.WriteLine("({0} restantes na pilha)", pilha.Tamanho);
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