using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.1.39.
    /// </summary>
    public class Exercicio1139_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o número de execuções: ");
                int T = Convert.ToInt32(Console.ReadLine());
                int[][] tabela = Matrix.InicializarMatriz<int>(T, 4);

                for (int i = 0; i < T; i++)
                {
                    for (int expoente = 3; expoente <= 6; expoente++)
                    {
                        int N = Convert.ToInt32(Math.Floor(Math.Pow(10, expoente)));
                        int[] vetorA = GeradorAleatorio.GerarInteiros(N, 100000, 999999);
                        int[] vetorB = GeradorAleatorio.GerarInteiros(N, 100000, 999999);

                        tabela[i][expoente - 3] = ContarElementosRepetidos(vetorA, vetorB);
                    }
                }

                double[] medias = CalcularMedias(T, tabela);

                ApresentarMedias(medias);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        private static void ApresentarMedias(double[] medias)
        {
            for (int i = 0; i < medias.Length; i++)
            {
                Console.WriteLine("Média de elementos repetidos para 10e{0}: {1}", i + 3, medias[i]);
            }
        }

        private static double[] CalcularMedias(int T, int[][] tabela)
        {
            double[] medias = new double[4];
            for (int i = 0; i < T; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    medias[j] += tabela[i][j];
                }
            }

            for (int i = 0; i < medias.Length; i++)
            {
                medias[i] /= T;
            }
            
            return medias;
        }

        private static int ContarElementosRepetidos(int[] vetorA, int[] vetorB)
        {
            int elementosRepetidos = 0;
            foreach (int elemento in vetorA)
            {
                if (BuscaBinaria.Rank(elemento, vetorB) != -1)
                {
                    elementosRepetidos++;
                }
            }

            return elementosRepetidos;
        }
    }
}