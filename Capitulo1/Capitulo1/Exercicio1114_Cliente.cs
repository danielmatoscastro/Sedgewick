using Capitulo1_Biblioteca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de teste para o exercício 1.1.14
    /// </summary>
    class Exercicio1114_Cliente
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um inteiro: ");
            int entrada = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("O piso de lg({0}) é {1}", entrada, Logaritmo.Lg(entrada));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
