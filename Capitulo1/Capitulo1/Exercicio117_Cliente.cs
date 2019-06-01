using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de testes para o exercício 1.1.7
    /// </summary>
    class Exercicio117_Cliente
    {
        static void Main(string[] args)
        {
            #region Fragmento (a)

            double t = 9.0;
            while (Math.Abs(t - 9.0 / t) > 0.001)
                t = (9.0 / t + t) / 2.0;

            Console.WriteLine(t);

            #endregion

            #region Fragmento (b)

            int sum = 0;
            for (int i = 0; i < 1000; i++)
                for (int j = 0; j < i; j++)
                    sum++;

            Console.WriteLine(sum);
            #endregion

            #region Fragmento (c)
            sum = 0;
            for (int i = 1; i < 1000; i *= 2)
                for (int j = 0; j < 1000; j++)
                    sum++;

            Console.WriteLine(sum);

            #endregion

            Console.ReadKey();
        }
    }
}
