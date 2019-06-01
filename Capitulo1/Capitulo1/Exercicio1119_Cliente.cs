using Capitulo1_Biblioteca;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de testes para o exercício 1.1.19
    /// </summary>
    class Exercicio1119_Cliente
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"fibonacci.txt"))
            {
                #region Cálculo de F(N) para 0 <= N < 100 (Função não otimizada)
                writer.WriteLine("Cálculo de F(N) para 0 <= N < 100 (Função não otimizada):");

                for (int N = 0; N < 100; N++)
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();

                    long Fn = Fibonacci.F(N);

                    sw.Stop();

                    writer.WriteLine("{0} => {1} | Tempo para cálculo: {2}",
                        N, Fn, sw.Elapsed.ToString());
                }
                #endregion

                writer.WriteLine("\n==============================================\n");

                #region Cálculo de F(N) para 0 <= N < 100 (Função otimizada)
                writer.WriteLine("Cálculo de F(N) para 0 <= N < 100 (Função otimizada):");

                for (int N = 0; N < 100; N++)
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();

                    long Fn = Fibonacci.FProgramacaoDinamica(N);

                    sw.Stop();

                    writer.WriteLine("{0} => {1} | Tempo para cálculo: {2}",
                        N, Fn, sw.Elapsed.ToString());
                }
                #endregion
            }

            Console.ReadKey();
        }
    }
}
