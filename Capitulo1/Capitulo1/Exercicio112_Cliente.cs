using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de testes para o exercício 1.1.2
    /// </summary>
    class Exercicio112_Cliente
    {
        static void Main(string[] args)
        {
            var letraA = (1 + 2.236) / 2;
            var letraB = 1 + 2 + 3 + 4.0;
            var letraC = 4.1 >= 4;
            var letraD = 1 + 2 + "3";

            Console.WriteLine("a) (1 + 2.236) / 2 | tipo = {0} | valor = {1}", letraA.GetType(), letraA);
            Console.WriteLine("b) 1 + 2 + 3 + 4.0 | tipo = {0} | valor = {1}", letraB.GetType(), letraB);
            Console.WriteLine("c) 4.1 >= 4 | tipo = {0} | valor = {1}", letraC.GetType(), letraC);
            Console.WriteLine("d) 1 + 2 + \"3\" | tipo = {0} | valor = {1}", letraD.GetType(), letraD);

            Console.ReadKey();
        }
    }
}
