using System;
using System.Runtime.InteropServices;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.2.1.
    /// </summary>
    public class Exercicio121_Cliente
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Digite o número de pontos: ");
                int N = Convert.ToInt32(Console.ReadLine());

                Random random = new Random(DateTime.Now.Millisecond);
                Point2DBook[] pontos = new Point2DBook[N];

                for (int i = 0; i < pontos.Length; i++)
                {
                    pontos[i] = new Point2DBook(random.NextDouble(), random.NextDouble());
                }

                double[][] distancias = Matrix.InicializarMatriz<double>(N, N);

                for (int i = 0; i < pontos.Length - 1; i++)
                {
                    for (int j = i; j < pontos.Length; j++)
                    {
                        double distancia = pontos[i].DistanceTo(pontos[j]);
                        distancias[i][j] = distancia;
                        distancias[j][i] = distancia;
                    }
                }

                double menorDistancia = distancias[0][1];

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (i != j && distancias[i][j] < menorDistancia)
                        {
                            menorDistancia = distancias[i][j];
                        }
                    }
                }

                Console.WriteLine("A menor distância entre dois pontos é {0}", menorDistancia);

            }
            catch (Exception ex)
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