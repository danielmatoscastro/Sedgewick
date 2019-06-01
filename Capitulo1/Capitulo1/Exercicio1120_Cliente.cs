using Capitulo1_Biblioteca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de testes para o exercício 1.1.20
    /// </summary>
    class Exercicio1120_Cliente
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("ln({0}!): ", i);
                Console.WriteLine("Exercício: {0} | Biblioteca: {1}", Logaritmo.LnFatorial(i), Math.Log(Fatorial.Fat(i)));
                Console.WriteLine("========================================================");
            }

            Console.ReadKey();
        }
    }
}
