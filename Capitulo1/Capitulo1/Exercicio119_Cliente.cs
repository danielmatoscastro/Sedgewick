using Capitulo1_Biblioteca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de testes para o exercício 1.1.9
    /// </summary>
    class Exercicio119_Cliente
    {
        static void Main(string[] args)
        {
            int[] numerosDecimais = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int numeroDecimal in numerosDecimais)
            {
                Console.WriteLine("{0} => {1}", numeroDecimal, ConversorDecBin.Converter(numeroDecimal));
            }

            Console.ReadKey();
        }
    }
}
