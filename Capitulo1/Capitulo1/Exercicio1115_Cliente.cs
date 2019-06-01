using Capitulo1_Biblioteca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de teste para o exercício 1.1.15
    /// </summary>
    class Exercicio1115_Cliente
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 0, 1, 0, 0, 1 };
            int[] array3 = { 2, 7 };

            int[] histograma1 = Histograma.GetHistograma(array1, 6);
            int[] histograma2 = Histograma.GetHistograma(array2, 2);
            int[] histograma3 = Histograma.GetHistograma(array3, 8);

            Console.WriteLine("Array 1: ");
            Console.WriteLine(ImpressorVetorial.ImprimeArray<int>(array1));
            Console.WriteLine("Histograma do array 1 (M = 6): ");
            Console.WriteLine(ImpressorVetorial.ImprimeArrayIndiceValor<int>(histograma1));

            Console.WriteLine("=========================================================");

            Console.WriteLine("Array 2: ");
            Console.WriteLine(ImpressorVetorial.ImprimeArray<int>(array2));
            Console.WriteLine("Histograma do array 1 (M = 2): ");
            Console.WriteLine(ImpressorVetorial.ImprimeArrayIndiceValor<int>(histograma2));

            Console.WriteLine("=========================================================");

            Console.WriteLine("Array 3: ");
            Console.WriteLine(ImpressorVetorial.ImprimeArray<int>(array3));
            Console.WriteLine("Histograma do array 1 (M = 8): ");
            Console.WriteLine(ImpressorVetorial.ImprimeArrayIndiceValor<int>(histograma3));

            Console.WriteLine("=========================================================");

            Console.ReadKey();
        }
    }
}
