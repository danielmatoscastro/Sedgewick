using System;
using System.CodeDom;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe cliente para o exercício 1.1.32
    /// </summary>
    public class Exercicio1132_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                LeitorDeLista leitor = new LeitorDeLista(@"../../doubles.txt");
                double[] a = leitor.Ler<double>();

                Histograma.PlotHistograma(a, 0, 100, 4);
                Console.WriteLine("Histograma gerado com sucesso.");
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