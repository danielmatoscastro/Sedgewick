using Capitulo1_Biblioteca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de teste para o exercício 1.1.11
    /// </summary>
    class Exercicio1111_Cliente
    {
        static void Main(string[] args)
        {
            bool[][] matrizA = {new bool[] { true, true },
                                new bool[] { true, true }};

            bool[][] matrizB = {new bool[] {true, false},
                                new bool[] {false, true}};

            bool[][] matrizC = {new bool[] {false, false},
                                new bool[] {false, false}};

            Console.WriteLine("Matriz A: ");
            Console.WriteLine(ImpressorMatricial.ImprimeMatrizBooleana(matrizA));
            Console.WriteLine("\n");

            Console.WriteLine("Matriz B: ");
            Console.WriteLine(ImpressorMatricial.ImprimeMatrizBooleana(matrizB));
            Console.WriteLine("\n");

            Console.WriteLine("Matriz C: ");
            Console.WriteLine(ImpressorMatricial.ImprimeMatrizBooleana(matrizC));
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
