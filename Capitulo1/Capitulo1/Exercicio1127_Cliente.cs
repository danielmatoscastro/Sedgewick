using Capitulo1_Biblioteca;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Capitulo1_Cliente
{
    class Exercicio1127_Cliente
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando Binomial(20, 10, 0.25): ");

            Console.WriteLine("================================================");

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Tuple<long, double> recursivo = DistribuicaoBinomial.BinomialComContagem(20, 10, 0.25);
            sw.Stop();

            Console.WriteLine("Recursivo: ");
            Console.WriteLine("Chamadas: {0}", recursivo.Item1);
            Console.WriteLine("Tempo: {0}", sw.Elapsed);
            Console.WriteLine("Resultado: {0}", recursivo.Item2);

            Console.WriteLine("================================================");

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            double progDinamica = DistribuicaoBinomial.BinomialProgramacaoDinamica(20, 10, 0.25);
            sw.Stop();

            Console.WriteLine("Programação Dinâmica: ");
            Console.WriteLine("Chamadas: 1");
            Console.WriteLine("Tempo: {0}", sw2.Elapsed);
            Console.WriteLine("Resultado: {0}", progDinamica);

            Console.WriteLine("================================================");

            Console.ReadKey();

        }
    }
}
