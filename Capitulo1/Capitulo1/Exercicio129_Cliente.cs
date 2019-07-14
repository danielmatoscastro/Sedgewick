using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.2.9.
    /// </summary>
    public class Exercicio129_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = GeradorAleatorio.GerarInteiros(10, 0, 7);
                Array.Sort(arr);

                Console.WriteLine("Amostra: ");
                Console.WriteLine(ImpressorVetorial.ImprimeArray<int>(arr));

                for (int i = 0; i <= 7; i++)
                {
                    Counter counter = new Counter(String.Format("Buscando {0}", i));
                    BuscaBinaria.Rank(i, arr, counter);
                    Console.WriteLine(counter);
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