using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de testes para o exercício 1.1.3
    /// </summary>
    class Exercicio113_Cliente
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o primeiro inteiro: ");
            int inteiro1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre com o segundo inteiro: ");
            int inteiro2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre com o terceiro inteiro: ");
            int inteiro3 = Convert.ToInt32(Console.ReadLine());

            if (inteiro1 == inteiro2 && inteiro2 == inteiro3)
            {
                Console.WriteLine("Iguais.");
            }
            else
            {
                Console.WriteLine("Diferentes.");
            }

            Console.ReadKey();
        }
    }
}
