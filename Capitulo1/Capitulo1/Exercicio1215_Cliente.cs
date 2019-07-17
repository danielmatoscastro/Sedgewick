using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.2.15.
    /// </summary>
    public class Exercicio1215_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                LeitorDeLista leitor = new LeitorDeLista(@"../../algs4-data/tinyT.txt");
                int[] elementos = leitor.LerInts();
                
                Console.WriteLine(ImpressorVetorial.ImprimeArray<int>(elementos));
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