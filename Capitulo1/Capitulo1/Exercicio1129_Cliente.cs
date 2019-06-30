using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de teste para o exercício 1.1.29
    /// </summary>
    public class Exercicio1129_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[] {1, 1, 2, 2, 2, 2, 2, 3, 5, 6, 7, 8, 8, 9, 10, 10};

                Console.WriteLine("Vetor: {0}", ImpressorVetorial.ImprimeArray<int>(arr));
                Console.WriteLine("Tamanho: {0}", arr.Length);

                for (int i = 0; i < arr.Length + 1; i++)
                {
                    Console.WriteLine("Quantidade de elementos iguais a {0}: {1}", i, BuscaBinaria.Count(i, arr));
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