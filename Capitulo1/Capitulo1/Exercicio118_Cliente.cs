using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de testes para o exercício 1.1.8
    /// </summary>
    class Exercicio118_Cliente
    {
        static void Main(string[] args)
        {
            Console.WriteLine('b');
            Console.WriteLine('b' + 'c');
            Console.WriteLine((char)'a' + 4);

            // As operações envolvendo variáveis do tipo char levam em conta seu valor ASCII.
            // Por isso os resultados das somas são numéricos.

            Console.ReadKey();
        }

    }
}
