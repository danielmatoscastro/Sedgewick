using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.1.35.
    /// </summary>
    public class Exercicio1135_Cliente
    {
        static void Main(string[] args)
        {
            int N = 1;
            
            SomaDeDadosExata exata = new SomaDeDadosExata();
            SomaDeDadosAproximada aproximada = new SomaDeDadosAproximada(N);
            
            while (!exata.Equals(aproximada))
            {
                N++;
                aproximada = new SomaDeDadosAproximada(N);
            }
            
            Console.WriteLine("N necessário para aproximação: {0}", N);
            Console.ReadKey();
        }
    }
}