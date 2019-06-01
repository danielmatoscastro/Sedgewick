using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de testes para o exercício 1.1.6
    /// </summary>
    class Exercicio116_Cliente
    {
        static void Main(string[] args)
        {
            int f = 0;
            int g = 1;
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine(f);
                f = f + g;
                g = f - g;
            }

            //Resposta: O código imprime a sequência de Fibonacci

            Console.ReadKey();
        }
    }
}
