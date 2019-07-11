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

                Point2DBook[] pontos = new Point2DBook[N];
                
                GerarPontos(pontos);

                double[][] distancias = Matrix.InicializarMatriz<double>(N, N);

                CalcularDistancias(pontos, distancias);

                double menorDistancia = EncontraMenorDistancia(distancias, N);

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

        private static double EncontraMenorDistancia(double[][] distancias, int N)
        {
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

            return menorDistancia;
        }

        private static void CalcularDistancias(Point2DBook[] pontos, double[][] distancias)
        {
            for (int i = 0; i < pontos.Length - 1; i++)
            {
                for (int j = i; j < pontos.Length; j++)
                {
                    double distancia = pontos[i].DistanceTo(pontos[j]);
                    distancias[i][j] = distancia;
                    distancias[j][i] = distancia;
                }
            }
        }

        private static void GerarPontos(Point2DBook[] pontos)
        {
            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < pontos.Length; i++)
            {
                pontos[i] = new Point2DBook(random.NextDouble(), random.NextDouble());
            }
        }
    }
}