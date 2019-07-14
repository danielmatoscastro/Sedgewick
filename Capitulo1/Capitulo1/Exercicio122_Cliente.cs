using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o 
    /// </summary>
    public class Exercicio122_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o número de intervalos: ");
                int N = Convert.ToInt32(Console.ReadLine());

                Interval1D[] intervalos = new Interval1D[N];

                LerIntervalos(N, intervalos);

                MostrarIntervalosQueSeIntersectam(N, intervalos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void MostrarIntervalosQueSeIntersectam(int N, Interval1D[] intervalos)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (intervalos[i].Intersects(intervalos[j]))
                    {
                        Console.WriteLine("Os intervalos {0} e {1} se intersectam.", intervalos[i], intervalos[j]);
                    }
                }
            }
        }

        private static void LerIntervalos(int N, Interval1D[] intervalos)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite o extremo esquerdo do intervalo {0}: ", i);
                double esq = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o extremo direito do intervalo {0}: ", i);
                double dir = Convert.ToDouble(Console.ReadLine());

                intervalos[i] = new Interval1D(esq, dir);
            }
        }
    }
}