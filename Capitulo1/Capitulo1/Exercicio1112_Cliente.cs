using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de teste para o exercício 1.1.12
    /// </summary>
    class Exercicio1112_Cliente
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for (int i = 0; i < 10; i++)
                a[i] = 9 - i;

            for (int i = 0; i < 10; i++)
                a[i] = a[a[i]];

            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);

            // Resposta: imprime os números inteiros de 0 a 9.

            Console.ReadKey();
        }
    }
}
