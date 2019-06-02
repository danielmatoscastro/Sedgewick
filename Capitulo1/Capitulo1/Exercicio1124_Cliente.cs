using Capitulo1_Biblioteca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de teste para o exercício 1.1.24
    /// </summary>
    class Exercicio1124_Cliente
    {
        static void Main(string[] args)
        {
            Tuple<StringBuilder, int> retorno = MaximoDivisorComum.MdcComRastreio(1111111, 1234567);

            Console.WriteLine("MDC entre 1111111 e 1234567: {0} ", retorno.Item2);

            Console.WriteLine("Execuções: ");
            Console.WriteLine(retorno.Item1.ToString());

            Console.ReadKey();
        }
    }
}
