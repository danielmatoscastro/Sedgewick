using Capitulo1_Biblioteca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de teste para o exercício 1.1.13
    /// </summary>
    class Exercicio1113_Cliente
    {
        static void Main(string[] args)
        {
            int[][] matrizA = {new int[] {1, 0},
                               new int[] {0, 1} };

            int[][] matrizB = {new int[] {1, 2, 3},
                               new int[] {4, 5, 6}};

            string[][] matrizC = {new string[] {"a", "b"},
                                  new string[] {"c", "d"}};

            Console.WriteLine("Matriz A: ");
            Console.WriteLine(ImpressorMatricial.ImprimeMatriz<int>(matrizA));
            Console.WriteLine("Matriz A transposta: ");
            Console.WriteLine(ImpressorMatricial.ImprimeMatriz<int>(matrizA));

            Console.WriteLine("======================================================");

            Console.WriteLine("Matriz B: ");
            Console.WriteLine(ImpressorMatricial.ImprimeMatriz<int>(matrizB));
            Console.WriteLine("Matriz B transposta: ");
            Console.WriteLine(ImpressorMatricial.ImprimeMatrizTransposta<int>(matrizB));

            Console.WriteLine("======================================================");

            Console.WriteLine("Matriz C: ");
            Console.WriteLine(ImpressorMatricial.ImprimeMatriz<string>(matrizC));
            Console.WriteLine("Matriz C transposta: ");
            Console.WriteLine(ImpressorMatricial.ImprimeMatrizTransposta<string>(matrizC));

            Console.WriteLine("======================================================");

            Console.ReadKey();
        }
    }
}
