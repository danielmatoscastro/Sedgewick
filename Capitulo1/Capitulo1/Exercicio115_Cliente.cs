using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de testes para o exercício 1.1.5
    /// </summary>
    class Exercicio115_Cliente
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o primeiro double: ");
            double double1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entre com o segundo double: ");
            double double2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(double1 > 0 && double1 < 1 && double2 > 0 && double1 < 1);

            Console.ReadKey();
        }
    }
}
